using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class BaseFigure
    {
        public int X,Y;
        public Boolean isMoved;
        protected int[,] figureMatrix;

        public BaseFigure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw(ref int[,] consoleMatrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(consoleMatrix[X + i, Y + j] == 0)
                        consoleMatrix[X + i, Y + j] = figureMatrix[i, j];
                }
            }
        }
    }

    class Square : BaseFigure
    {
        public Square(int X, int Y) : base(X,Y)
        {  
            figureMatrix = new int[5, 5] {  { 1, 1, 1, 1, 1 }, 
                                            { 1, 0, 0, 0, 1 },
                                            { 1, 0, 0, 0, 1 },
                                            { 1, 0, 0, 0, 1 },
                                            { 1, 1, 1, 1, 1 } };
        }
    }

    class Triangle : BaseFigure
    {
        public Triangle(int X, int Y) : base(X, Y)
        {
            figureMatrix = new int[5, 5] {  { 0, 0, 1, 0, 0 },
                                            { 0, 1, 0, 1, 0 },
                                            { 0, 1, 0, 1, 0 },
                                            { 1, 0, 0, 0, 1 },
                                            { 1, 1, 1, 1, 1 } };
        }
    }

    class Circle : BaseFigure
    {
        public Circle(int X, int Y) : base(X, Y)
        {
            figureMatrix = new int[5, 5] {  { 0, 0, 1, 0, 0 },
                                            { 0, 1, 0, 1, 0 },
                                            { 1, 0, 0, 0, 1 },
                                            { 0, 1, 0, 1, 0 },
                                            { 0, 0, 1, 0, 0 } };
        }
    }
}
