class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number: ");
        int a = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for(int i = 2; i<a; i++)
        {
            if(a%1==0)
            isPrime=false;
        }
        Console.Write(isPrime);
    }
}