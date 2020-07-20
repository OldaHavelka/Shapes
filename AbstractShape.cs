using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class AbstractShape
    {
        protected string name = "Abstract shape.";
        protected string numberOfSides = "Undefined ammout of sides.";
        protected string aStringIwantToKeep = "Mr. Stringer";
        public abstract string AmmountOfSides();
        public abstract string NameOfShape();
        public abstract string AStringIwantToKeep();
        public abstract string Name { get; }
        public abstract string NumberOfSides { get; }
        public abstract string TheKeptString { get; }
    }
}
