using System;
using System.IO;

namespace cSharpBasic
{
    public class fileReadWriteDemo
    {
        public void writeFile()
        {
            StreamWriter sw = new StreamWriter("/home/aavash/RiderProjects/cSharpBasic/cSharpBasic/files/1.txt");
            Console.WriteLine("insert text to enter: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush();
            sw.Close();
        }

        public void readFile()
        {
            StreamReader sr = new StreamReader("/home/aavash/RiderProjects/cSharpBasic/cSharpBasic/files/1.txt");
            string data1 = sr.ReadLine();
            Console.WriteLine();
            sr.Close();
        }
    }
}