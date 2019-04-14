using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Using the C# language, have the function MaximalSquare(strArr) take the strArr parameter being passed which will 
 be a 2D matrix of 0 and 1's, and determine the area of the largest square submatrix that contains all 1's. A square 
 submatrix is one of equal width and height, and your program should return the area of the largest submatrix that contains 
 only 1's. For example: if strArr is ["10100", "10111", "11111", "10010"] then this looks like the following matrix: 

1 0 1 0 0
1 0 1 1 1
1 1 1 1 1
1 0 0 1 0 

For the input above, you can see the bolded 1's create the largest square submatrix of size 2x2, so your program should
return the area which is 4. You can assume the input will not be empty. 

Hard challenges are worth 15 points and you are not timed for them.
*/
namespace MaximalSquare_Matrix
{
    class MatrixNode
    {
        public int X = -1;
        public int Y = -1;
        public void Pos(int x_, int y_)
        {
            X = x_;
            Y = y_;
        }
        public char Char = 'E';
        public string Name = "Null";
        public void Connections(MatrixNode up, MatrixNode down, MatrixNode right, MatrixNode left)
        {
            Up = up;
            Down = down;
            Right = right;
            Left = left;
        }
        public MatrixNode Up = null;
        public MatrixNode Down = null;
        public MatrixNode Right = null;
        public MatrixNode Left = null;

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = { "111" ,
                                   "111" ,
                                   "111" };//Console.ReadLine();

            MaximalSquare(userInput);
            Console.ReadLine();
        }
        static void MaximalSquare(string[] strArray)
        {
            int xMax = strArray[0].ToCharArray().Count();
            int yMax = strArray.Count();
            InitiateNodes(xMax,yMax, strArray);



        }
        /// <summary>
        /// Guarda los nodes en X y Y
        /// </summary>
        static MatrixNode[,] matrixNodesArray;
        static void InitiateNodes(int xMax, int yMax, string[] strArray)
        {
            matrixNodesArray = new MatrixNode[xMax , yMax];
            for (int y = 0; y < yMax; y++)
            {
                for (int x = 0; x < xMax; x++)
                {
                    MatrixNode node = new MatrixNode();
                    node.Pos(x, y);
                    node.Name = "N " + (y * xMax + x);
                    node.Char = strArray[y].ToCharArray()[x];
                    matrixNodesArray[x, y] = node;
                }
            }
            ConnectNodes(xMax, yMax);
        }
        static void ConnectNodes(int xMax, int yMax)
        {
            for (int y = 0; y < yMax; y++)
            {
                for (int x = 0; x < xMax; x++)
                {
                    try { matrixNodesArray[x, y].Up    = matrixNodesArray[x    , y + 1]; }
                    catch { }
                    try { matrixNodesArray[x, y].Down  = matrixNodesArray[x    , y - 1]; }
                    catch { }
                    try { matrixNodesArray[x, y].Right = matrixNodesArray[x + 1, y    ]; }
                    catch { }
                    try { matrixNodesArray[x, y].Left  = matrixNodesArray[x - 1, y    ]; }
                    catch { }
                }
            }
        }
    }
}
