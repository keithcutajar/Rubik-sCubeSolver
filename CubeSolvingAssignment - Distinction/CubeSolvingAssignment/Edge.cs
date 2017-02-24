using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolvingAssignment
{
    public class Edge
    {
        public Node newCube { get; set; }
        public Node oldCube { get; set; }
        public Faces face { get; set; }
        public Directions direction { get; set; }
        public int weight;

        public Edge(Node oldCube, Node newCube, Faces face, Directions diraction)
        {
            this.newCube = newCube;
            this.oldCube = oldCube;
            this.face = face;
            this.direction = diraction;
            this.weight = 1;
        }

        public override string ToString()
        {
            return face + " " + direction;
        }
    }
}
