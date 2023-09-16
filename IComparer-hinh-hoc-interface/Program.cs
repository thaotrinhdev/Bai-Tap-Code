namespace Shape
{
    class Program
    {
        public static void Main(String[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("red", false);
            Console.WriteLine(shape);
            Console.WriteLine("Hello World");

            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);

            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);
            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);

            Circle[] circles = new Circle[3];
            circles[0] = new (3.5, "indigo", false);
            circles[1] = new (35, "pink", true);
            circles[2] = new (32, "orange", true);
            Console.WriteLine("Pre-sorted");
            foreach (Circle array in circles)
            {
                Console.WriteLine(array);
            }
            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (Circle array in circles)
            {
                Console.WriteLine(array);

            }
        }
    }
}