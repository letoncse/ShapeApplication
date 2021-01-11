using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object
            Circle circle = new Circle(1);
            Console.WriteLine(circle.ToString());

            // Create a Triangle object
            Triangle triangleFirst = new Triangle(5, 8, 9);
            Console.WriteLine(triangleFirst.ToString());

            Triangle triangleSecond = new Triangle(3, 3, 3);
            Console.WriteLine(triangleSecond.ToString());

            Triangle triangleThird = new Triangle(4, 4, 5);
            Console.WriteLine(triangleThird.ToString());

            // Create a Rectangle object
            Rectangle rectangle = new Rectangle(3, 3);
            Console.WriteLine(rectangle.ToString());

            // Create a Square object
            Square square = new Square(3);
            Console.WriteLine(square.ToString());

            // Create a List of Shape type object
            List<Shape> baseShapes = new List<Shape>();
            baseShapes.Add(circle);
            baseShapes.Add(triangleFirst);
            baseShapes.Add(triangleThird);
            baseShapes.Add(rectangle);
            baseShapes.Add(square);

            Console.WriteLine();

            var sortedList = baseShapes.OrderBy(p => p.SurfaceArea()); 
            PrintShapes(sortedList, "Shapes ordered by Surface Area");

            sortedList = baseShapes.OrderBy(p => p.Perimeter());
            PrintShapes(sortedList, "Shapes ordered by Perimeter");

            string Json = GetJsonString(triangleFirst);
            Console.WriteLine("Json is" + Json);

            PrintCountOfShapes();

            Console.ReadLine();
        }

        private static void PrintShapes(IEnumerable<Shape> sortedList, string message)
        {
            Console.WriteLine(message);
            foreach (var baseShape in sortedList)
            {
                Console.WriteLine(baseShape);
            }
            Console.WriteLine();
        }

        public static string GetJsonString(Shape obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static void PrintCountOfShapes()
        {
            Console.WriteLine();
            Console.WriteLine("the number of Circle    is  " + Circle.Count);
            Console.WriteLine("the number of triangle  is  " + Triangle.Count);
            Console.WriteLine("the number of Square    is  " + Square.Count);
            Console.WriteLine("the number of Rectangle is  " + Rectangle.Count);
        }
    }
}
