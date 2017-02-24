using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolvingAssignment
{
    public enum ShortestRoute { BellmanFord, Dijkstra }

    public class Graph
    {

        


        public List<Edge> Edges;

        public Node RootCube { get; set; }

        public List<Node> Nodes
        {
            get
            {
                List<Node> result = new List<Node>();


                if (Edges.Count > 0)
                {
                    
                    foreach(var e in Edges)
                    {
                        if (!result.Contains(e.oldCube))
                        {
                            result.Add(e.oldCube);
                        }
                        if (!result.Contains(e.newCube))
                        {
                            result.Add(e.newCube);
                        }
                    }

                }
                else
                {
                    result.Add(RootCube);
                }


                return result;
            }
        }


        public Graph(Node rootCube)
        {
            RootCube = rootCube;
            RootCube.isVisited = false;
            Edges = new List<Edge>();
        }

        public void CreateGraph()
        {
            while (IsGraphSolved() == null)
            {
                var node = GetNonVisitedNode();
                var node1 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Front, Directions.Clockwise) };
                var node2 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Front, Directions.Anticlockwise) };

                var node3 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Back, Directions.Clockwise) };
                var node4 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Back, Directions.Anticlockwise) };

                var node5 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Right, Directions.Clockwise) };
                var node6 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Right, Directions.Anticlockwise) };

                var node7 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Top, Directions.Clockwise) };
                var node8 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Top, Directions.Anticlockwise) };

                var node9 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Bottom, Directions.Clockwise) };
                var node10 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Bottom, Directions.Anticlockwise) };

                var node11 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Left, Directions.Clockwise) };
                var node12 = new Node { CubeNode = node.CubeNode.RotateCube(Faces.Left, Directions.Anticlockwise) };

                var edge = new Edge(node, node1, Faces.Front, Directions.Clockwise);
                var edge2 = new Edge(node, node2, Faces.Front, Directions.Anticlockwise);

                var edge3 = new Edge(node, node3, Faces.Back, Directions.Clockwise);
                var edge4 = new Edge(node, node4, Faces.Back, Directions.Anticlockwise);

                var edge5 = new Edge(node, node5, Faces.Right, Directions.Clockwise);
                var edge6 = new Edge(node, node6, Faces.Right, Directions.Anticlockwise);

                var edge7 = new Edge(node, node7, Faces.Top, Directions.Clockwise);
                var edge8 = new Edge(node, node8, Faces.Top, Directions.Anticlockwise);

                var edge9 = new Edge(node, node9, Faces.Bottom, Directions.Clockwise);
                var edge10 = new Edge(node, node10, Faces.Bottom, Directions.Anticlockwise);

                var edge11 = new Edge(node, node11, Faces.Left, Directions.Clockwise);
                var edge12 = new Edge(node, node12, Faces.Left, Directions.Anticlockwise);

                AddEdge(edge);
                AddEdge(edge2);
                AddEdge(edge3);
                AddEdge(edge4);
                AddEdge(edge5);
                AddEdge(edge6);
                AddEdge(edge7);
                AddEdge(edge8);
                AddEdge(edge9);
                AddEdge(edge10);
                AddEdge(edge11);
                AddEdge(edge12);

                node.isVisited = true;
            }


        }

        public Node IsGraphSolved()
        {
            foreach (var node in Nodes)
            {
                if (node.CubeNode.CubeIsSolved())
                {
                    var count = Nodes.Count();
                    return node;
                }
            }
            return null;
        }


        public Node NodeExists(Node node)
        {      
            foreach(var n in Nodes)
            {
                if (node.IsEqualTo(n))
                {
                    return n;
                }
            }
            return null;
        }

        public void AddEdge(Edge edge)
        {
            if (NodeExists(edge.newCube) != null)
            {
                edge.newCube = NodeExists(edge.newCube);
            }
            Edges.Add(edge);
        }

        public Node GetNonVisitedNode()
        {
            return Nodes.FirstOrDefault(node => node.isVisited == false);
        }

        public int IndexOf(Node node)
        {
            return Nodes.IndexOf(node);
        }

        public List<Edge> BellmanFord(Graph g)
        {
            //initialize data structures

            var distance = new int[g.Nodes.Count];
            var predecessor = new Edge[g.Nodes.Count];

            for (int i = 1; i < g.Nodes.Count; i++)
            {
                distance[i] = int.MaxValue;
            }

            //Relaxation

            Parallel.For(0, g.Nodes.Count - 1, i =>
            {

                Parallel.For(0, g.Edges.Count - 1, j =>
                {
                    Edge e = g.Edges[j];
                    if ((distance[g.IndexOf(e.oldCube)] + e.weight) < distance[g.IndexOf(e.newCube)])
                    {
                        distance[g.IndexOf(e.newCube)] = (distance[g.IndexOf(e.oldCube)] + e.weight);
                        predecessor[g.IndexOf(e.newCube)] = e;
                    }
                });
            });

            //for(int i = 0; i < g.Nodes.Count - 1; i++)
            //{
            //    for (int j = 0; j < g.Edges.Count; j++)
            //    {
            //        Edge e = g.Edges[j];
            //        if ((distance[g.IndexOf(e.oldCube)] + e.weight) < distance[g.IndexOf(e.newCube)])
            //        {
            //            distance[g.IndexOf(e.newCube)] = (distance[g.IndexOf(e.oldCube)] + e.weight);
            //            predecessor[g.IndexOf(e.newCube)] = e;
            //        }
            //    }
            //}

            //Compute Path

            var destIndex = g.IndexOf(IsGraphSolved());
            Edge pre;
            var result = new List<Edge>();

            do
            {
                pre = predecessor[destIndex];
                destIndex = IndexOf(pre.oldCube);
                result.Add(pre);
            }
            while (!pre.oldCube.CubeNode.GridMap.SequenceEqual(RootCube.CubeNode.GridMap));

            result.Reverse();
            return result;

        }


        public List<Edge> Dijkstra(Graph g, Node source)
        {
            //Initialize
            var nodes = new List<Node>();
            var distance = new int[g.Nodes.Count];
            var predecessor = new Edge[g.Nodes.Count];


            //int counter = 0;
            foreach (var n in g.Nodes)
            {

                distance[IndexOf(n)] = int.MaxValue;
                predecessor[IndexOf(n)] = null;
                nodes.Add(n);
            }
            distance[IndexOf(source)] = 0;



            Node minimumDist = new Node();//initializing
            while (nodes.Count != 0)
            {

/*
                minimumDist = distance.Min();

                var distance1 = distance.Min();

                minimumDist = 
                */
                foreach (var n in nodes)
                {
                    //var index = nodes.IndexOf(n);
                    //var index2 = index + 1;

                    //if (index2 != g.Nodes.Count)
                    //{
                    //   if (distance[index] < distance[index2])
                    //    {
                    //        minimumDist = n;

                    //    }
     
                    //}

                    


                }
                nodes.Remove(minimumDist);



                foreach (var v in getNeighbours(minimumDist))
                {

                    var edge = getEdge(minimumDist, v);
                    var alt = distance[IndexOf(minimumDist)] + edge.weight;

                    if (alt < distance[IndexOf(v)])
                    {
                        distance[IndexOf(v)] = alt;
                        predecessor[IndexOf(v)] = edge;
                    }
                }
            }

            var destIndex = g.IndexOf(IsGraphSolved());
            Edge pre;
            var result = new List<Edge>();

            do
            {            
                pre = predecessor[destIndex];
                destIndex = IndexOf(pre.oldCube);
                result.Add(pre);
            }
            while (!pre.oldCube.CubeNode.GridMap.SequenceEqual(RootCube.CubeNode.GridMap));

            result.Reverse();
            return result;
        }



        public Edge getEdge(Node u, Node v)
        {
            foreach (var e in Edges)
            {
                if (e.oldCube.CubeNode.GridMap.SequenceEqual(u.CubeNode.GridMap) && e.newCube.CubeNode.GridMap.SequenceEqual(v.CubeNode.GridMap))
                {
                    return e;
                }

            }
            return null;
        }


        public List<Node> getNeighbours(Node node)
        {
            var list = new List<Node>();
            foreach (var edge in Edges)
            {
                if (edge.oldCube.IsEqualTo(node))
                {
                    list.Add(edge.newCube);
                }
            }

            return list;
        }

        public List<Edge> GetSolution(ShortestRoute sh)
        {
            if(sh== ShortestRoute.BellmanFord)
            {
                return BellmanFord(this);
            }
            else
            {

       
           // var dijkstra = new Dijkstra(this);
           // dijkstra.Execute(RootCube);
           // return dijkstra.GetPath(IsGraphSolved());
        
                return Dijkstra(this, RootCube);
            }

            

            
        }
    }
}
