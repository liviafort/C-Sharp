using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //MODULES


public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y); //LAMBDA EXPRESSION
    public override string ToString() => $"({X}, {Y})"; //YOU CAN MODIFY
}

public struct TaggedInteger
{
    public int Number;
    private List<string> tags;
    public TaggedInteger(int n)
    {
        Number = n;
        tags = new List<string>();
    }
    public void AddTag(string tag) => tags.Add(tag); //LAMBDA EXPRESSION
    public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
}

namespace learning
{
    internal class Program
    {
        static void Main(string[] args) //(LIKE C/C++)
        {
            FirstCode();
            Types();
            OperatorsAndExpression();
        }

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }

        private static void FirstCode()
        {
            string text = "Hello World";
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("My name is Livia Fortunato.");
            Types();
        }
        private static void Types()
        {

            /*EXAMPLE OF THE REFERENCE GUIDE:
             * -> THIS CODE ONLY CHANGES THE VARIABLE VALUES, (SIMPLE)
             */
            MutablePoint p1 = new MutablePoint(1, 2); //INSTANCE
            MutablePoint p2 = p1;
            p2.Y = 200;

            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");

            MutateAndDisplay(p2); //CALL
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");

            //ANOTHER EXAMPLE OF THE GUIDE
            var n1 = new TaggedInteger(0); //INSTANCE
            n1.AddTag("A");
            Console.WriteLine(n1);

            var n2 = n1;
            n2.Number = 7;
            n2.AddTag("B");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

        private static void OperatorsAndExpression()
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            Console.WriteLine($"{a}, {b}, {c}");
            b = a + b * c;
            c = a >= 100 ? b : c / 10;
            Console.WriteLine($"{a}, {b}, {c}");
            a = (int)Math.Sqrt(b * b + c * c);

            string s = "String literal";
            char l = s[s.Length - 1]; //FIND THE LAST CARACTERE
            Console.WriteLine(l);

            List<int> numbers = new List<int>(new[] { 1, 2, 3 });
            b = numbers.FindLast(n => n > 1); //LAST NUMBER GREATER THAN ONE
            Console.WriteLine(b);

         
            double r = 2.3d;
            string message = $"The area of a circle with radius {r} is {Math.PI * r * r:F3}.";
            string anotherMessage = $"The cos of {r} is {Math.Cos(r)}";  //MATH IS A LIB
            Console.WriteLine(message);
            Console.WriteLine(anotherMessage);


            int[] numbers2 = { 2, 3, 4, 5 };
            int maximumSquare = numbers2.Max(x => x * x);
            Console.WriteLine(maximumSquare);

            int[] scores = new[] { 90, 97, 78, 68, 85 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Console.WriteLine(string.Join(" ", highScoresQuery));

            Console.Read(); //WAIT PUSH ENTER
        }

        public static void DeclarationStatement()
        {
            
            //List<double> xs = new(); INITIAL VALUE

            //CONSTANTES
            const string greeting = "Hello";
            const double MinLimit = -10.0, MaxLimit = -MinLimit;
            //if you use var the compiler will infer the type


        }

    }
}