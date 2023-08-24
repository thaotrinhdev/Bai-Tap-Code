class Program
{
    static void Main(string[] args)
    {
          Console.WriteLine("Menu");
          Console.WriteLine("1. Draw the triangle");
          Console.WriteLine("2. Draw the square");
          Console.WriteLine("3. Draw the rectangle");
          Console.WriteLine("0. Exit");
          Console.WriteLine("Enter your choice: ");
          int a = int.Parse(Console.ReadLine());

          switch(a)
          {
            case 1:
            Console.WriteLine("Draw the triangle");
            Console.WriteLine("******");
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
            break;

            case 2:
            Console.WriteLine("Draw the square");
            Console.WriteLine("* * * * * *");
            Console.WriteLine("* * * * *  ");
            Console.WriteLine("* * * *    ");
            Console.WriteLine("* * *      ");
            Console.WriteLine("* *        ");
            Console.WriteLine("*          ");
            break;

            case 3:
            Console.WriteLine("Draw the square");
            Console.WriteLine("*          ");
            Console.WriteLine("* *        ");
            Console.WriteLine("* * *      ");
            Console.WriteLine("* * * *    ");
            Console.WriteLine("* * * * *  ");
            Console.WriteLine("* * * * * *");
            break;

            case 0:
            Environment.Exit(0);// Thoát 
            break;

            default:
            Console.WriteLine("No choice");
            break;
          }

    }
}
