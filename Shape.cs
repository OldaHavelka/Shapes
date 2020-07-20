using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape : AbstractShape, ICalculatable
    {
        public Shape()
        {
            this.name = Name;
            this.numberOfSides = NumberOfSides;
        }

        public override string Name => name;

        public override string NumberOfSides => numberOfSides;

        public override string TheKeptString => aStringIwantToKeep;

        public override string AmmountOfSides()
        {
            return NumberOfSides; 
        }

        public virtual string Area()
        {
            return "You cannot calculate with me yet! I do not have any properties yet!";
        }

        public override string AStringIwantToKeep()
        {
            return TheKeptString;
        }

        public virtual string Circumference()
        {
            return "You cannot calculate with me yet! I do not have any properties yet!";
        }

        public override string NameOfShape()
        {
            return Name;
        }
    }
}
