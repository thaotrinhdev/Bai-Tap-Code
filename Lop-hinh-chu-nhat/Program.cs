namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap chieu dai: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu cao: ");
            double b = double.Parse(Console.ReadLine());

            Rectangle retangle = new Rectangle(a,b);
            Console.WriteLine("Hinh chu nhat \n"+ retangle.Display());
            Console.WriteLine("Chu vi: "+ retangle.GetPerimeter()+"cm");
            Console.WriteLine("Dien tich: "+ retangle.GetArea()+"cm");



        }
    }
}
