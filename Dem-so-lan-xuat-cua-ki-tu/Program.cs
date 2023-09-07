namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int [] Name = {1,4,6,7,88,9,0,22,7,5,7,22,5,7,8,99};
            Console.WriteLine(",4,6,7,88,9,0,22,7,5,7,22,5,7,8,99");
            Console.Write("Enter the character you want to delete: ");
            int a =int.Parse(Console.ReadLine());
            for(int i =0 ; i<Name.Length;i++)
            {
                if(Name[i]== a)
                {
                    count++;
                }
                
            }
            Console.Write($"{a} has {count} times");
            
        }
    }
}
