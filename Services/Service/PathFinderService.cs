using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Service
{
    internal class Vertex
    {
        public PositioningNetElement positioningNetElement { get; }
        public double Dist { get; set; }
        public Vertex Prev { get; set; }

        public Vertex()
        {

        }

        public Vertex(PositioningNetElement positioningNetElement)
        {
            this.positioningNetElement = positioningNetElement;
            this.Dist = double.PositiveInfinity;
            this.Prev = null;
        }

        public Vertex(PositioningNetElement positioningNetElement, double dist, Vertex prev)
        {
            this.positioningNetElement = positioningNetElement;
            this.Dist = dist;
            this.Prev = prev;
        }

        public Vertex[] GetNeighbors(PositionedRelation[] allRelations, Vertex[] allVertices)
        {
            PositioningNetElement[] allNetElements = allVertices.Select(x => x.positioningNetElement).ToArray();

            PositioningNetElement[] neighborNetElements = positioningNetElement.GetRelations(allRelations, allNetElements);
            IList<Vertex> neighborVertices = new List<Vertex>();

            foreach(PositioningNetElement neighborNetElement in neighborNetElements)
            {
                IEnumerable<Vertex> vertices = allVertices.Where(x => x.positioningNetElement == neighborNetElement);
                if (vertices == null || vertices.Any() == false) continue;
                Vertex vertex = vertices.First();
                if (vertex == null) continue;

                neighborVertices.Add(vertex);
            }

            return neighborVertices.ToArray();
        }

        public double Length(Vertex neighbor)
        {
            PositioningNetElement neighborNetElement = neighbor.positioningNetElement;
            PositioningNetElement localNetElement = this.positioningNetElement;

            return neighborNetElement.Distance(localNetElement);
        }
    }

    public class PathFinderService
    {
        private Vertex minDist(Vertex[] allVertices)
        {
            Vertex min = null;
            double dist = double.PositiveInfinity;

            foreach(Vertex vertex in allVertices)
            {
                if(vertex.Dist < dist)
                {
                    min = vertex;
                    dist = vertex.Dist;
                }
            }

            return min;
        }

        public PositioningNetElement[] FindShortestPath(PositionedRelation[] positionedRelations, PositioningNetElement[] positioningNetElements, PositioningNetElement start, PositioningNetElement end)
        {
            IList<PositioningNetElement> shortestPath = new List<PositioningNetElement>();

            IList<Vertex> vertices = positioningNetElements.Select(x => new Vertex(x)).ToList();
            Vertex[] savedVertices = new Vertex[vertices.Count];

            vertices.CopyTo(savedVertices, 0);

            Vertex startVertex = savedVertices.Where(x => x.positioningNetElement == start).First();
            Vertex endVertex = savedVertices.Where(x => x.positioningNetElement == end).First();

            if (startVertex == null || endVertex == null) return null; // start and end should be in all elements

            startVertex.Dist = 0;

            Vertex u = null;
            while(vertices.Count != 0)
            {
                u = minDist(vertices.ToArray());

                vertices.Remove(u);

                if(u == endVertex)
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
                    break;
                }

                Vertex[] neighbors = u.GetNeighbors(positionedRelations, vertices.ToArray());
                foreach(Vertex neighbor in neighbors)
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
            Vertex[] prev = savedVertices.Select(x => x.Prev).ToArray();

            return shortestPath.ToArray();
        }
    }
}
