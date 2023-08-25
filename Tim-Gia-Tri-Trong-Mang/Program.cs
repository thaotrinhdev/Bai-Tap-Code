class Program
{
    static void Main(string[] args)
    {
        string[]student = {"Linh", "Nguyet","Thi","Ngoc","Tran"};
        Console.WriteLine("Enter a name's studen: ");
        string name = Console.ReadLine();

        for(int i = 0 ; i<student.Length;i++)
        {
            if(name.ToUpper() == student[i].ToUpper())
            {Console.WriteLine("Position of the students in the list" + name + "is:"+(i+1));
            return;}
        }
         Console.WriteLine("Not found" + name + "in the list.");
    }
}
