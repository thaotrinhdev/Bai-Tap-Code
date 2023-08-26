class Program
{
    static void Main(string[] args)
    {
        int size;
        int [] array;
        do
        {
            Console.WriteLine("nhap so luong so ban muon co trong mang: ");
            size=int.Parse(Console.ReadLine());
            if(size>20)
            {
                Console.WriteLine("Khong dur dieu kien");
            }
        }
        while(size>20);
        array=new int[size];
        for(int i=0;i<array.Length;i++)
        {
            Console.WriteLine($"ban da nhap {i+1} vao mang");
            array[i]= int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mang cúa ban co nhung so sau: ");
        for(int j=0;j<array.Length;j++)
        {
            Console.WriteLine(array[j]+"\t");
        }
        int max= array[0];
        int index=1;
        for(int j=0;j<array.Length;j++)
        {
            if(array[j]>max)
            {
                max=array[j];
                index =j+1;
            }
        }
        Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);
    }
}
