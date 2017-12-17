using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector2D
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            Console.Write("Enter x value for Vector 1: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y value for Vector 1: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Vector2D v = new Vector2D(x, y);

            Console.Write("Enter x value for Vector 2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y value for Vector 2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Vector2D v2 = new Vector2D(x2, y2);

            Console.WriteLine("Vector values are: " + v + " and " + v2);

            while (!quit) { 
                Console.WriteLine(" ");
                Console.WriteLine("Press N to show the negated values of the vector #1");
                Console.WriteLine("Press A to add to the vectors #1 and #2");
                Console.WriteLine("Press S to subtract Vectors #1 and #2");
                Console.WriteLine("Press C to scale the vector");
                Console.WriteLine("Press M to get the magnitude of the vector #1");
                Console.WriteLine("Press D to get the vector in degrees #1");
                Console.WriteLine(" ");
                Console.WriteLine("Part 2");
                Console.WriteLine("Press O to Normalize the vector #1");
                Console.WriteLine("Press T to get the Dot Product of the vector #1 and #2");
                Console.WriteLine(" ");
                Console.WriteLine("Press Q to Quit");

                char kOption = Console.ReadKey().KeyChar;

                switch (kOption) {
                    case 'N':
                    case 'n':
                        v.negateX();
                        v.negateY();
                        Console.WriteLine("\nYour vector values negated are: (" + v.X + "," + v.Y + ")");
                        Console.WriteLine(" ");
                        break;
                    case 'A':
                    case 'a':
                        v.addVector(x2, y2);
                        Console.WriteLine("\nYour vector added is: (" + v.X + "," + v.Y + ")");
                        Console.WriteLine(" ");
                        break;
                    case 'S':
                    case 's':
                        v.subtractVector(x2, y2);
                        Console.WriteLine("\nYour vector subtracted is: (" + v.X + "," + v.Y + ")");
                        Console.WriteLine(" ");
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("\nType the scalar: ");
                        double scalar = Convert.ToDouble(Console.ReadLine());
                        v.scalarMultiplication(scalar);
                        Console.WriteLine("\nYour vector 1 scaled is: (" + v.X + "," + v.Y + ")");
                        break;
                    case 'M':
                    case 'm':
                        Console.WriteLine("\nThe magnitude of the vector #1 is: ");
                        Console.WriteLine(v.getMagnitude());
                        break;
                    case 'D':
                    case 'd':
                        Console.WriteLine("\nThe angle of the vector #1 in degrees is : ");
                        Console.WriteLine(v.getDegrees());
                        break;
                    case 'O':
                    case 'o':
                        v.Normalize();
                        Console.WriteLine("\nThe vector #1 normalized is: (" + v.X + " , " + v.Y + ")");
                        break;
                    case 'T':
                    case 't':
                        v.getDot(x2, y2);
                        Console.WriteLine("\nThe vector #1 normalized is: (" + v.X + " , " + v.Y + ")");
                        break;
                    case 'Q':
                    case 'q':
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nWrong option. Please choose one of the correct options.");
                        Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}