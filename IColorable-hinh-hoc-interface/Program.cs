namespace Shape
{
    class Program
    {
        public static void Main(String[] args)
        {
            Square square= new Square(4, "red", true);
            Console.WriteLine(square.GetColor());
        }
    }
}