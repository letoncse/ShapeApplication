using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class Circle : Shape
    {
        public static int Count { get; private set; } = 0;
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Count++;
            Name = Constants.CircleName;
            Radius = radius;
        }
        public override double Perimeter() // Call the abstract method
        {
            return 2 * Math.PI * Radius;
        }
        public override double SurfaceArea() // Call the abstract method
        {
            return Math.PI * Radius * Radius;
        }
    }
}
