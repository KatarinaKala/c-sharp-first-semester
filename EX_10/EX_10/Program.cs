using System;

namespace EX_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            //dice.RandomNumber();

            string input = "";
            while (input != "e")
            {
                Console.CursorTop = 10;
                Console.CursorLeft = 0;
                Console.WriteLine("If you want to roll again press enter. If you want to exsit, press 'e'.");
                input = Console.ReadLine();
                dice.RandomNumber();
            }

            Console.ReadLine();
        }

        class Dice
        {
            Random rand = new Random();

            //Drawing the outer shape 7x7 for dice 
            public Dice()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if ((i == 0 || i == 6) || (j == 0 || j == 6))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            //Method for displaying random number inside the dice
            public void RandomNumber()
            {
                int number = rand.Next(1, 7);

                Console.CursorLeft = 2;
                Console.CursorTop = 2;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        //Third task to display random number inside dice
                        /* if (i == 1 && j == 1)
                         {
                             Console.Write(number);
                         }
                         else
                         {
                             Console.Write(" ");
                         }*/

                        switch (number)
                        {
                            case 1:
                                DrawNr1(i, j);
                                break;
                            case 2:
                                DrawNr2(i, j);
                                break;
                            case 3:
                                DrawNr3(i, j);
                                break;
                            case 4:
                                DrawNr4(i, j);
                                break;
                            case 5:
                                DrawNr5(i, j);
                                break;
                            case 6:
                                DrawNr6(i, j);
                                break;
                            default:
                                break;
                        }
                    }
                    Console.Write("\n");
                    Console.CursorLeft = 2;
                }
                Console.WriteLine();
            }

            public void DrawNr1(int i, int j)
            {
                if (i == 1 && j == 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            public void DrawNr2(int i, int j)
            {
                if (i == 1 && (j == 0 || j == 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            public void DrawNr3(int i, int j)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            public void DrawNr4(int i, int j)
            {
                if (i != 1 && j != 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            public void DrawNr5(int i, int j)
            {
                if ((i != 1 && j != 1) || (i == 1 && j == 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            public void DrawNr6(int i, int j)
            {
                if (j == 0 || j == 2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

    }
}
