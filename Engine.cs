using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Engine
    {
        private int[,] consoleMatrix;

        private void printConsoleMatrix()
        {
            for (int i = 0; i < consoleMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < consoleMatrix.GetLength(1); j++)
                {
                    if (consoleMatrix[i, j] == 1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                //Console.WriteLine();
            }
        }

        public void Start()
        {
            consoleMatrix = new int[24, 80];

            Square s = new Square(0,0);
            Triangle t = new Triangle(2,10);
            Circle c = new Circle(10,4);
            s.isMoved = true;

            BaseFigure[] figureArray = new BaseFigure[3] { s, t, c };

            while (true)
            {
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                    break;

                Array.Clear(consoleMatrix, 0, consoleMatrix.Length);
                Console.Clear();

                foreach (BaseFigure figure in figureArray)
                {
                    if (figure.isMoved)
                    {
                        switch (key.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (figure.X > 0)
                                {
                                    figure.X--;
                                }
                                break;
                            case ConsoleKey.DownArrow:
                                if (figure.X < 19)
                                {
                                    figure.X++;
                                }
                                break;
                            case ConsoleKey.LeftArrow:
                                if (figure.Y > 0)
                                {
                                    figure.Y--;
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                if (figure.Y < 75)
                                {
                                    figure.Y++;
                                }
                                break;
                            default:
                                break;
                        }
                    }

                    figure.Draw(ref consoleMatrix);
                }

                printConsoleMatrix();
            }
        }
    }
}
