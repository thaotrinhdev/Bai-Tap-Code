namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] array = new int[5];
            int c;
            
            Console.Write("Moi ban nhap so can chen: ");
            int a= int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap vị trí can chen: ");
            int b= int.Parse(Console.ReadLine());
            
            Console.Write("In mang ban dau: ");
            for(int i =0;i<b;i++)
            {
                Console.WriteLine(array[i]);
            }
            for(int i = a; i>=b; i--)
            {
                array[i]= array[i-1];
            }
            array[b]=a;
            Console.WriteLine("Sau khi chen ta co mang như sau: ");
            for(int i=0; i<=array.Length;i++)
            {
                Console.WriteLine(array[i]+"\t");
            }

            
        }
    }
}