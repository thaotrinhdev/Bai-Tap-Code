class Program
{
    static void Main(string[] args)
    {
        int VND = 230000;
        Console.Write("Mời bạn nhập số tiền cần quy đổi: ");
        string tien= Console.ReadLine();
        int tienQuyDoi = int.Parse(tien);
        int USD = tienQuyDoi * VND;
        Console.WriteLine("{0} USD bằng {1} VND",tien,USD);


    }
}