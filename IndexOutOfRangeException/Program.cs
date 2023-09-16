using System;
using System.Collections.Generic;
namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> character = new List<char>();
                // InsertRange: Chen doi tuong
                character.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = character[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
