namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Start time is :");
            // DateTime a = DateTime.Parse(Console.ReadLine());
            // Console.Write("End time is :");
            // DateTime b = DateTime.Parse(Console.ReadLine());
            // Stopwatch stopwatch = new Stopwatch();
            // Console.WriteLine($"GetEplaped:{stopwatch.GetEplapsed(a,b)}");

            int[] array = {33,55,22,53,86, 99};
            Console.WriteLine("Array is 33,55,22,53,86,99");
            foreach(var i in BubbleSort(array)) {
                Console.WriteLine($"{i}");
            }
            

        }
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {

                    if(array[j]<array[minIndex])
                    {
                        minIndex=j;
                    }
                }
                int temp = array[i];
                array[i]= array[minIndex];
                array[minIndex]= temp;

                
            }
            return array;
        }
    }
}