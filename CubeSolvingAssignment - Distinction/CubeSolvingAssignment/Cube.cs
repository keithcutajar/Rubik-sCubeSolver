using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CubeSolvingAssignment
{


    public enum Faces
    {
        Left, Top, Front, Bottom, Right, Back
    }

    public enum Directions
    {
        Clockwise, Anticlockwise
    }

    public class Cube
    {
        public int[] extendedFront = { 8, 9, 10, 11, 6, 7, 16, 18, 13, 12, 3, 1 };
        public int[] extendedRight = { 16, 17, 18, 19, 7, 5, 20, 22, 15, 13, 11, 9 };
        public int[] extendedBack = { 20, 21, 22, 23, 5, 4, 0, 2, 14, 15, 19, 17 };
        public int[] extendedBottom = { 12, 13, 14, 15, 10, 11, 18, 19, 22, 23, 2, 3 };
        public int[] extendedTop = { 4, 5, 6, 7, 21, 20, 17, 16, 9, 8, 1, 0 };
        public int[] extendedLeft = { 0, 1, 2, 3, 4, 6, 8, 10, 12, 14, 23, 21 };

        public Dictionary<Faces, int[]> ExtendedFaces;

        public Color[] GridMap { get; set; }

        public Color[] Colors =
        {
            Color.Green, Color.White, Color.Red, Color.Yellow, Color.Blue, Color.Orange
        };

        public Cube()
        {
            GridMap = new Color[24]; //24 colors becaue 24 squares

            for (int i = 0; i < 24; i++)
            {
                GridMap[i] = Colors[i / 4];
            }

            ExtendedFaces = new Dictionary<Faces, int[]>
            {
                {Faces.Front, extendedFront },
                 {Faces.Back, extendedBack },
                 {Faces.Left, extendedLeft },
                 {Faces.Bottom, extendedBottom },
                 {Faces.Top, extendedTop },
                {Faces.Right, extendedRight }
            };
        }

        public Cube(Color[]col, Dictionary<Faces,int[]> extendedFaces)
        {

            this.GridMap = (Color[])col.Clone();
            ExtendedFaces = extendedFaces;
        }

        public Cube RotateCube(Faces face,Directions direction)
        {
            Cube result = new Cube();
            switch (direction)
            {
                case Directions.Clockwise:
                    result = RotateCW(ExtendedFaces[face]);
                    break;

                case Directions.Anticlockwise:
                    result = RotateACW(ExtendedFaces[face]);
                    break;

            }
            return result;
        }

        public Cube RotateCW(int[] cubeSide)
        {
            Cube result = new Cube(this.GridMap, ExtendedFaces);
            result.GridMap[cubeSide[0]] = this.GridMap[cubeSide[2]];
            result.GridMap[cubeSide[1]] = this.GridMap[cubeSide[0]];
            result.GridMap[cubeSide[3]] = this.GridMap[cubeSide[1]];
            result.GridMap[cubeSide[2]] = this.GridMap[cubeSide[3]];

            result.GridMap[cubeSide[4]] = this.GridMap[cubeSide[10]];
            result.GridMap[cubeSide[5]] = this.GridMap[cubeSide[11]];
            result.GridMap[cubeSide[6]] = this.GridMap[cubeSide[4]];
            result.GridMap[cubeSide[7]] = this.GridMap[cubeSide[5]];

            result.GridMap[cubeSide[8]] = this.GridMap[cubeSide[6]];
            result.GridMap[cubeSide[9]] = this.GridMap[cubeSide[7]];
            result.GridMap[cubeSide[11]] = this.GridMap[cubeSide[8]];
            result.GridMap[cubeSide[10]] = this.GridMap[cubeSide[9]];

            return result;
        }

        public Cube RotateACW(int[] cubeSide)
        {
            Cube result = new Cube(GridMap, ExtendedFaces);
            result.GridMap[cubeSide[2]] = this.GridMap[cubeSide[0]];
            result.GridMap[cubeSide[0]] = this.GridMap[cubeSide[1]];
            result.GridMap[cubeSide[1]] = this.GridMap[cubeSide[3]];
            result.GridMap[cubeSide[3]] = this.GridMap[cubeSide[2]];

            result.GridMap[cubeSide[10]] = this.GridMap[cubeSide[4]];
            result.GridMap[cubeSide[11]] = this.GridMap[cubeSide[5]];
            result.GridMap[cubeSide[4]] = this.GridMap[cubeSide[6]];
            result.GridMap[cubeSide[5]] = this.GridMap[cubeSide[7]];

            result.GridMap[cubeSide[6]] = this.GridMap[cubeSide[8]];
            result.GridMap[cubeSide[7]] = this.GridMap[cubeSide[9]];
            result.GridMap[cubeSide[8]] = this.GridMap[cubeSide[11]];
            result.GridMap[cubeSide[9]] = this.GridMap[cubeSide[10]];

            return result;
        }

        public bool CubeIsSolved()
        {
            var tmpColor = Color.AliceBlue;
            for (int i = 0; i < GridMap.Length; i++)
            {
                if (i % 4 == 0)
                {
                    tmpColor = GridMap[i];
                }
                if (GridMap[i] != tmpColor)
                {
                    return false;
                }
            }
            return true;
        }





    }
}
