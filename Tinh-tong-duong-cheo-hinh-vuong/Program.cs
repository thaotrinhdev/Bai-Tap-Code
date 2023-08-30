using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array= {{1,4,5},{4,7,3},{2,6,9}};
            int total= 0;
            for(int i = 0; i<array.GetLength(0);i++)
            {
                total+= array[i,i];
            }
            Console.WriteLine($"Total is {total}");

        }
    }
}