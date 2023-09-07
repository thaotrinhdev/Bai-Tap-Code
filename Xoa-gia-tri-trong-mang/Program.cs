namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= {2,6,4,8,9,11,89};
            Console.Write(" Array is 2,6,4,8,9,11,89. Chose your number need to delete: ");
            int a = int.Parse(Console.ReadLine());
            deleteItem(array,a);
        }
        public static void deleteItem( int [] array, int number)
        {
            // Kiểm tra xem có số cần xoá hay không?
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
            int indexToDelete = -1;
            for(int i = 0 ; i<array.Length;i++)
            {
                if(array[i] == number)
                {
                    indexToDelete=i;
                }
            }
            // Nếu không có thì báo lại và thoát
            if(indexToDelete==-1)
            {
                Console.WriteLine($" Dont have a number + {number}");
                return;
            }
            // Nếu tìm thấy rồi thì xoá số đó và sắp xếp lại vị trí
            // Chỗ nào trống sẽ điền 0 vào
            for(int i = indexToDelete;i<array.Length;i++)
            {
                if(i==array.Length-1)
                {
                    array[i]=0;
                }
                else
                {
                    array[i]= array[i+1];
                }
                    
            }
            Console.WriteLine("Have a number: ");
            for(int j = 0 ; j<array.Length;j++)
            {
                Console.Write(array[j]+" ");
            }

        }
    }
    
}
