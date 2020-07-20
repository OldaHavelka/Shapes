using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape undefShape = new Shape();

            Console.WriteLine(undefShape.NameOfShape());
            Console.WriteLine(undefShape.AmmountOfSides());
            Console.WriteLine(undefShape.Area());
            Console.WriteLine(undefShape.Circumference());
            Console.WriteLine(undefShape.AStringIwantToKeep());

            Console.WriteLine("----------");

            //undefShape.NumberOfSides = 3;   This shouldn't work. And it doesn't. So it works as expected.
            Line line = new Line();

            Console.WriteLine(line.NameOfShape());
            Console.WriteLine(line.AmmountOfSides());
            Console.WriteLine(line.Area());
            Console.WriteLine(line.Circumference());
            Console.WriteLine(line.AStringIwantToKeep());

            Console.WriteLine("----------");

            Square firstSquare = new Square();
            firstSquare.A = 5;
            firstSquare.B = 10;
            Console.WriteLine(firstSquare.NameOfShape());
            Console.WriteLine(firstSquare.AmmountOfSides());
            Console.WriteLine(firstSquare.Area());
            Console.WriteLine(firstSquare.Circumference());
            Console.WriteLine(firstSquare.AStringIwantToKeep());
            firstSquare.A = 15;
            Console.WriteLine(firstSquare.Area());
            Console.WriteLine(firstSquare.Circumference());

            Console.WriteLine("----------");

            Square secondSquare = new Square(7, 2);
            Console.WriteLine(secondSquare.NameOfShape());
            Console.WriteLine(secondSquare.AmmountOfSides());
            Console.WriteLine(secondSquare.Area());
            Console.WriteLine(secondSquare.Circumference());
            Console.WriteLine(secondSquare.AStringIwantToKeep());
            secondSquare.A = 15;
            Console.WriteLine(secondSquare.Area());
            Console.WriteLine(secondSquare.Circumference());


            Console.ReadLine();
        }
    }
}
