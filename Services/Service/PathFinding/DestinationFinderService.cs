using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.Translation;
using Services.DependencyInjection;
using Services.Managers.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service.PathFinding
{
    public class DestinationFinderService : IService
    {
        private PositioningNetElementManager positioningNetElementManager;

        public DestinationFinderService()
        {
            this.positioningNetElementManager = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance();
        }

        public List<PositioningNetElement> FindPossibleDestinations(EulynxDataPrep eulynx, string uuidStart, bool includePassed)
        {
            if (eulynx == null || uuidStart == null) return null;

            List<PositionedRelation> relations = eulynx.ownsRtmEntities.usesTrackTopology.usesPositionedRelation;
            List<PositioningNetElement> netElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

            PositioningNetElement startNetElement = positioningNetElementManager.Find(netElements, uuidStart);

            return FindPossibleDestinations(startNetElement, netElements, relations, includePassed);
        }

        public List<PositioningNetElement> FindPossibleDestinations(PositioningNetElement start, List<PositioningNetElement> positioningNetElements, List<PositionedRelation> allPositionedRelations, bool includePassed)
        {
            List<PositioningNetElement> foundDestinations = new List<PositioningNetElement>();

            List<PathFindingVertex> vertices = positioningNetElements.Select(x => new PathFindingVertex(x)).ToList();
            PathFindingVertex[] savedVertices = new PathFindingVertex[vertices.Count];
            vertices.CopyTo(savedVertices, 0);

            PathFindingVertex startVertex = savedVertices.Where(x => x.positioningNetElement == start).First();

            startVertex.Dist = 0;

            PathFindingVertex u = null;
            while (vertices.Count != 0)
            {
                u = PathFindingVertex.minDist(vertices.ToArray());

                if (u == null) break;

                vertices.Remove(u);

                List<PathFindingVertex> neighbors = u.GetNeighbors(allPositionedRelations, vertices);
                if (includePassed)
                {
                    if (!u.positioningNetElement.Equals(start))
                    {
                        foundDestinations.Add(u.positioningNetElement);
                    }
                }
                else if(neighbors.Count == 0 || neighbors.Any(n => savedVertices.Contains(n)) == false)
                {
                    // u is a destination
                    foundDestinations.Add(u.positioningNetElement);
                    continue;
                }
                foreach (PathFindingVertex neighbor in neighbors)
                {
                    if (!savedVertices.Contains(neighbor))
                    {
                        // Prevent looping for circular connections
                        if (! foundDestinations.Contains(neighbor.positioningNetElement))
                        {
                            // Two tracks coming to one, with a destination further on

                            if(neighbor.Prev != null && !foundDestinations.Contains(neighbor.Prev.positioningNetElement))
                            {
                                // Add other side of merging track to destinations too.
                                // Both tracks before the merging switch are destinations.
                                foundDestinations.Add(neighbor.Prev.positioningNetElement);
                            }
                        }
                        continue;
                    }

                    var alt = u.Dist + u.Length(neighbor);

                    if (alt < neighbor.Dist)
                    {
                        neighbor.Dist = alt;
                        neighbor.Prev = u;
                    }
                }
            }

            return foundDestinations;
        }
    }
}
