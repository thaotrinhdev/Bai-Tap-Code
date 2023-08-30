namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            float nhietDoC= 50;
            double nhietDoF= doC(nhietDoC);
            Console.WriteLine($"Tong: {nhietDoF}");
        }
        public static double doC(double c)
        {
            double f=(9.0/5)*c+32;
            return f;
        }
        public static double doF(double f)
        {
            double c =(5.0 / 9) * (f - 32);
            return c;
        }
    }
}
