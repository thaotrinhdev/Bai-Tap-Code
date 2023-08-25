class Program
{
    static void Main(string[] args)
    {
        int [] num = new int []{2,5,9,7,6};

        Console.WriteLine(num[1]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num[4]);

        int total = 0;
        for(int i=0; i<num.Length;i++)
        {
            total= total+num[i];
        }
        Console.WriteLine($"Total is: {total}");
    }
    
}
