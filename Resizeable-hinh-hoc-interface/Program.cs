﻿namespace Shape
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Shape shape = new Shape();
            // Console.WriteLine(shape);
            // shape = new Shape("red", false);
            // Console.WriteLine(shape);
            // Console.WriteLine("Hello World");

            // Circle circle = new Circle();
            // Console.WriteLine(circle);
            // circle = new Circle(3.5);
            // Console.WriteLine(circle);
            // circle = new Circle(3.5, "indigo", false);
            // Console.WriteLine(circle);

            // Rectangle rectangle = new Rectangle();
            // Console.WriteLine(rectangle);
            // rectangle = new Rectangle(2.3, 5.8);
            // Console.WriteLine(rectangle);
            // rectangle = new Rectangle(2.5, 3.8, "orange", true);
            // Console.WriteLine(rectangle);

            // Square square = new Square();
            // Console.WriteLine(square);
            // square = new Square(2.3);
            // Console.WriteLine(square);
            // square = new Square(5.8, "yellow", true);
            // Console.WriteLine(square);
            Circle circle = new Circle(5);
            double circleSize= 50;

            Console.WriteLine("Before resize");
            Console.WriteLine(circle.ToString());

            Console.WriteLine();
            circle.Resize(circleSize);
            Console.WriteLine($"After resize: {circle.GetRadius()}");

            circle.Resize(circleSize);
            circle.ToString();

            
        }
    }
}