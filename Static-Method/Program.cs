namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(33,"Khanh");
            Student s2 = new Student(344,"Chi");

            s1.Display();
            s2.Display();
        }
    }
}
