class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Menu");
       Console.WriteLine("1.Print the rectangle");
       Console.WriteLine("2.Print the square triangle");
       Console.WriteLine("3.Print isosceles triangle");
       Console.WriteLine("4.Exit");
       Console.WriteLine("Your choice: ");
       int choice= int.Parse(Console.ReadLine());

       int w = 10;
       int h = 5;

       switch(choice)
       {
        case 1:
        {
            for(int a=0; a<h;a++)
            {
                for(int b=0; b<w;b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        break;
        case 2:
        {
            for(int a=0; a<=w;a++)
            {
                for(int b= 1; b<=a;b++)
                {
                    Console.Write("*");
                }
                w--;
                Console.WriteLine("");
            }
        }
        break;
        case 3:
        {
            for(int a=1; a<w;a++)
            {
                for(int b= 1; b<=a;b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        break;
        case 4:
        Environment.Exit(choice);
        break;
        default:
        Console.WriteLine("No choice");
        break;
       }
    }
    
}
