class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = int.Parse(Console.ReadLine());

        if(a!= 0)
        {
            double result = -b/a;
            Console.WriteLine($"The solution is: {result}");
        }
        else
        {
            if(b!= 0)
            {
                Console.Write("Nod solution!");
            }
            else
            Console.Write("The solution is all x!");
            
        }
    }
}
