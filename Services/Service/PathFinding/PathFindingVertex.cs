using Models.TopoModels.EULYNX.rtmCommon;
using Services.DependencyInjection;
using Services.Managers.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service.PathFinding
{
    class PathFindingVertex
    {
        public PositioningNetElement positioningNetElement { get; }
        public double Dist { get; set; }

        /// <summary>
        /// Vertex where path finding previously was
        /// This will lead back to source
        /// </summary>
        public PathFindingVertex Prev { get; set; }

        public PathFindingVertex()
        {

        }

        public PathFindingVertex(PositioningNetElement positioningNetElement)
        {
            this.positioningNetElement = positioningNetElement;
            this.Dist = double.PositiveInfinity;
            this.Prev = null;
        }

        public PathFindingVertex(PositioningNetElement positioningNetElement, double dist, PathFindingVertex prev)
        {
            this.positioningNetElement = positioningNetElement;
            this.Dist = dist;
            this.Prev = prev;
        }

        public static PathFindingVertex minDist(PathFindingVertex[] allVertices)
        {
            PathFindingVertex min = null;
            double dist = double.PositiveInfinity;

            foreach (PathFindingVertex vertex in allVertices)
            {
                if (vertex.Dist < dist)
                {
                    min = vertex;
                    dist = vertex.Dist;
                }
            }

            return min;
        }

        public List<PathFindingVertex> GetNeighbors(List<PositionedRelation> allRelations, List<PathFindingVertex> allVertices)
        {
            List<PositioningNetElement> allNetElements = allVertices.Select(x => x.positioningNetElement).ToList();


            List<PositioningNetElement> neighborNetElements;
            if (this.Prev != null)
            {
                Usage cameFrom = getCameFrom(this.Prev, allRelations);
                neighborNetElements = this.positioningNetElement.GetRelationsTraversable(allRelations, allNetElements, cameFrom);
            }
            else
            {
                neighborNetElements = this.positioningNetElement.GetRelations(allRelations, allNetElements);
            }

            List<PathFindingVertex> neighborVertices = new List<PathFindingVertex>();

            foreach (PositioningNetElement neighborNetElement in neighborNetElements)
            {
                IEnumerable<PathFindingVertex> vertices = allVertices.Where(x => x.positioningNetElement == neighborNetElement);
                if (vertices == null || vertices.Any() == false) continue;
                PathFindingVertex vertex = vertices.First();
                if (vertex == null) continue;

                neighborVertices.Add(vertex);
            }

            return neighborVertices;
        }

        public Usage getCameFrom(PathFindingVertex previous, List<PositionedRelation> allRelations)
        {
            Usage cameFrom;

            var prm = InstanceManager.Singleton<PositionedRelationManager>().GetInstance();
            var relation = prm.GetRelation(this.positioningNetElement, previous.positioningNetElement, allRelations);

            if (this.positioningNetElement.Equals(relation.elementA))
            {
                cameFrom = relation.positionOnA;
            }
            else
            {
                cameFrom = relation.positionOnB;
            }

            return cameFrom;
        }

        public double Length(PathFindingVertex neighbor)
        {
            PositioningNetElement neighborNetElement = neighbor.positioningNetElement;
            PositioningNetElement localNetElement = this.positioningNetElement;

            return neighborNetElement.Distance(localNetElement);
        }
    }
}
