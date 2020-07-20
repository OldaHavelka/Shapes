using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public override string Name => "Square!";
        public override string NumberOfSides => "Four!";

        private int a;
        private int b;
        public int A { get { return 3; } set { a = value; } }
        public int B { get { return 3; } set { b = value; } }

        public Square()
        {
            this.name = Name;
            this.numberOfSides = NumberOfSides;
        }

        public Square(int a, int b) {
            this.name = Name;
            this.numberOfSides = NumberOfSides;
            this.a = a;
            this.b = b;
        }

        public override string Circumference()
        {
            return "Circumference = "+((this.a+this.b)*2).ToString();
        }

        public override string Area()
        {
            return "Area = "+(this.a*this.b).ToString();
        }
    }
}
