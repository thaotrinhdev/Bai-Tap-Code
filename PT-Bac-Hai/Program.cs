class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tinh PT Bac 2: ax2+bx+c=0");
        Console.WriteLine("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        if(a==0)
        {
            if (b == 0)
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
            else
            {
                Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
            }
            return;
        }
        

        //Tinh detal
        double detal= b*b - 4 *a * c;
        double x1;
        double x2;
        
        //Tinh nghiem
        if(detal>0)
        {
            x1 = ((-b + Math.Sqrt(detal)) / (2 * a));
            x2 = ((-b - Math.Sqrt(detal)) / (2 * a));
        }
        else if (detal == 0)
        {
            x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
        }
        else
        {
            Console.Write("Phuong trinh vo nghiem!");
        }


    }
}