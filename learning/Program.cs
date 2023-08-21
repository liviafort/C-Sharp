using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //MODULES


public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);
    public override string ToString() => $"({X}, {X})"; //YOU CAN MODIFY
}


namespace learning
{
    internal class Program
    {
        static void Main(string[] args) //(LIKE C/C++)
        {
            string text = "Hello World";
            for(int i = 0; i<200; i++){
                Console.WriteLine(text);
            }

            Console.WriteLine("My name is Livia Fortunato.");

            /*EXAMPLE OF THE REFERENCE GUIDE:
             * -> THIS CODE ONLY CHANGES THE VARIABLE VALUES, (SIMPLE)
             */
            MutablePoint p1 = new MutablePoint(1, 2); //CALL
            MutablePoint p2 = p1;
            p2.Y = 200;

            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2); //CALL
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
            Console.Read(); //WAIT PUSH ENTER
        }

        //SEE THE DIFFERENCE BETWEEN A FUNCTION AND A STRUCT 

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }
    }
}