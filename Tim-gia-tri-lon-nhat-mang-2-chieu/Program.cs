namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x=3, y=5;
            int [,] array= new int [x,y]{{2,4,6,7,8},{13,45,28,46,88},{9,40,39,57,37}};

            int min= array[0,0];
            int max = array[0,0];
            for(int i=0;i<x;i++)
            {
                for(int j=0; j<y; j++)
                {
                    if(array[i,j]>max)
                    {
                        max= array[i,j];
                    }
                    if(array[i,j]< min)
                    {
                        min = array[i,j];
                    }
                }
            }
            Console.Write("Mang ta co: \t ");
            for(int i=0;i<x;i++)
            {
                for(int j = 0; j<y;j++)
                {
                    Console.Write($"{array[i,j] + ","}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Gia tri lon nhat {max}");
            Console.WriteLine($"Gia tri lon nhat {min}");
        }

    }
}