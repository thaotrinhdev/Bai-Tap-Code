class Program{
    static void Main(string[] args)
    {
        Console.Write("Please enter a height: ");
        double h = double.Parse(Console.ReadLine());
        Console.Write("Please enter a weight: ");
        double w = double.Parse(Console.ReadLine());
        double bmi = w/Math.Pow(h,2);
        bmi = Math.Round(bmi,2);
        Console.WriteLine($"BMI: {bmi}");

        if(bmi<18.5)
        {
            Console.WriteLine("Underweight");
        }
          else if(bmi <25.0)
        {
            Console.WriteLine("Normal");
        }
          else if(bmi<30.0)
        {
            Console.WriteLine("Overweight");
        }
        else
        Console.WriteLine("Obese");
    }
}
