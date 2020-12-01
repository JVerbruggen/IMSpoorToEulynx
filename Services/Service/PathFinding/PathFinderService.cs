using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.Translation;
using Services.DependencyInjection;
using Services.Managers.Topology;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service.PathFinding
{
    public class PathFinderService : IService
    {
        public PositioningNetElement[] FindShortestPath(PositionedRelation[] allPositionedRelations, PositioningNetElement[] positioningNetElements, PositioningNetElement start, PositioningNetElement end)
        {
            IList<PositioningNetElement> shortestPath = new List<PositioningNetElement>();

            IList<PathFindingVertex> vertices = positioningNetElements.Select(x => new PathFindingVertex(x)).ToList();
            PathFindingVertex[] savedVertices = new PathFindingVertex[vertices.Count];
            vertices.CopyTo(savedVertices, 0);

            PathFindingVertex startVertex = savedVertices.Where(x => x.positioningNetElement == start).First();
            PathFindingVertex endVertex = savedVertices.Where(x => x.positioningNetElement == end).First();

            if (startVertex == null || endVertex == null) return null; // start and end should be in all elements

            startVertex.Dist = 0;

            PathFindingVertex u = null;
            while(vertices.Count != 0)
            {
                u = PathFindingVertex.minDist(vertices.ToArray());

                if (u == null) break;

                vertices.Remove(u);

                if(u == endVertex) // If reached destination
                {
                    u = endVertex;
                    if (u.Prev != null || u == startVertex)
                    {
                        while (u != null)
                        {
                            shortestPath.Insert(0, u.positioningNetElement);
                            u = u.Prev;
                        }
                    }
                    break; // end of algorithm
                }

                PathFindingVertex[] neighbors = u.GetNeighbors(allPositionedRelations, vertices.ToArray());
                foreach(PathFindingVertex neighbor in neighbors)
                {
                    var alt = u.Dist + u.Length(neighbor);

                    if(alt < neighbor.Dist)
                    {
                        neighbor.Dist = alt;
                        neighbor.Prev = u;
                    }
                }
            }

            double[] dist = savedVertices.Select(x => x.Dist).ToArray();
            PathFindingVertex[] prev = savedVertices.Select(x => x.Prev).ToArray();

            return shortestPath.ToArray();
        }

        public PositioningNetElement[] FindShortestPath(Eulynx eulynx, string refStartNetElement, string refEndNetElement)
        {
            if (eulynx == null) return null;

            PositioningNetElementManager positioningNetElementManager = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance();

            PositionedRelation[] relations = eulynx.ownsRtmEntities.usesTrackTopology.usesPositionedRelation;
            PositioningNetElement[] netElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

            PositioningNetElement startNetElement = positioningNetElementManager.Find(netElements, refStartNetElement);
            PositioningNetElement endNetElement = positioningNetElementManager.Find(netElements, refEndNetElement);

            PositioningNetElement[] shortestPath = FindShortestPath(relations, netElements, startNetElement, endNetElement);

            return shortestPath;
        }
    }
}
