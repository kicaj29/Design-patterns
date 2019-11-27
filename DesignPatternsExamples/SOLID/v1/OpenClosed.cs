using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.v1
{
    class OpenClosed
    {
        //-------wrong approach-------
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        public class Circle
        {
            public double Radius { get; set; }
            public double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }

        public class AreaCalculatorV1
        {
            public double Area(Rectangle[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    area += shape.Width * shape.Height;
                }

                return area;
            }
        }

        public class AreaCalculatorV2
        {
            // to support Circle this function had to be modified with if/else that checks the type
            public double Area(object[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    if (shape is Rectangle)
                    {
                        Rectangle rectangle = (Rectangle)shape;
                        area += rectangle.Width * rectangle.Height;
                    }
                    else
                    {
                        Circle circle = (Circle)shape;
                        area += circle.Radius * circle.Radius * Math.PI;
                    }
                }

                return area;
            }
        }


        //-------correct approach-------
        public abstract class Shape
        {
            public abstract double Area();
        }
        public class RectangleOK : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area()
            {
                return Width * Height;
            }
        }
        public class CircleOK : Shape
        {
            public double Radius { get; set; }
            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
        }

        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
