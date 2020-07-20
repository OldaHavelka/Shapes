using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Line : Shape
    {
        public override string Name => "Line.";
        public override string NumberOfSides => "One. Or two?";

        public Line() {
            this.name = Name;
            this.numberOfSides = NumberOfSides;
        }

        public override string Area() {
            return "Does a line have area? I honestly do not know.";
        }

        public override string Circumference()
        {
            return "Circumference = a. Or is it 2*a?";
        }
    }
}
