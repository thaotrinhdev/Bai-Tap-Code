using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int size;
        int [] array;
        do
        {
            Console.WriteLine("Moi ban nhap day so cua ban mong muon: ");
            size= int.Parse(Console.ReadLine());
            if(size>20)
            {
                Console.WriteLine("Khong hop le: ");
            }
        }
        while(size>20);
        array= new int[size];
        for(int i = 0; i< array.Length;i++)
        {
            Console.WriteLine($"Ban da nhap {i+1} vao mang");
            array[i]= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mang co nhung so sau: ");
        for(int j=0 ; j< array.Length; j++)
        {
            Console.WriteLine(array[j]+"\t");
        }
        int min = array[0];
        int index= 1;
        for(int a=0; a<array.Length;a++)
        {
            if(array[a]< min)
            {
                min= array[a];
                index = a + 1;
            }
        }
         Console.WriteLine("Gia tri nho nhat " + min + " , o vi tri " + index);

    }
}
