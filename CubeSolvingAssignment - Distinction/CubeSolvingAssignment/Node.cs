using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeSolvingAssignment
{
    public class Node
    {

        public Cube CubeNode { get; set; }

        public bool isVisited { get; set; }


        public bool IsEqualTo(Node node)
        {
            for (int i = 0; i < node.CubeNode.GridMap.Length; i++)
            {
                if(this.CubeNode.GridMap[i] != node.CubeNode.GridMap[i])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
