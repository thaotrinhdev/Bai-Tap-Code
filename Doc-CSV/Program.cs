using System;
using System.IO;
namespace Name
{
    class ReadTextFileExample
    {
        static void Main(string[] args)
        {
            string path = "file.csv";
            StreamReader reader = new StreamReader(path);
            StreamWriter writer = new StreamWriter("file_01.csv");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] spearator = line.Split(',');
                spearator[5] = spearator[5].Replace("\"", "");
                writer.Write(spearator[5]);
                writer.WriteLine("");
            }
            reader.Close();
            writer.Close();
        }

    }


}
