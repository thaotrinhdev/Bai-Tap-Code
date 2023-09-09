namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Console.WriteLine(fan1.ToString(3,"yellow",10,"on","fan1"));
            Fan fan2 = new Fan();
            Console.WriteLine(fan2.ToString(1,"blue",5,"off","fan2"));
        }
    }
}
