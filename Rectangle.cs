using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public static int Count { get; private set; } = 0;
        public Rectangle(double width, double height)
        {
            Count++;
            Name = Constants.RectangleName;

            this.Width = width;
            this.Height = height;

        }

        public override double Perimeter() // Call the abstract method
        {
            return (Width + Height) * 2;
        }

        public override double SurfaceArea() // Call the abstract method
        {
            return Width * Height;
        }
    }
}
