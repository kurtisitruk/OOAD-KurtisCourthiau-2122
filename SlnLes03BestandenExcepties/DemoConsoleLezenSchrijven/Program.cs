using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleLezenSchrijven
{
    class Program
    {
        static void Main(string[] args)
        {
            // define working folder
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            List<string> lines = new List<string>();
            lines.Add("Dit is lijn 1");
            lines.Add("Dit is lijn 2");

            // WRITING FILES

            // 1: write using StreamWriter and WriteLine()
            string filePath1 = System.IO.Path.Combine(folderPath, "myfile1.txt");
            using (StreamWriter writer = File.CreateText(filePath1))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            } 

            // 2: write using File.WriteAllLines()
            string filePath2 = System.IO.Path.Combine(folderPath, "myfile2.txt");
            File.WriteAllLines(filePath2, lines);

            // 3: write using File.WriteAllText()
            string content3 = @"Dit is regel 1
Dit is regel 2";
            string filePath3 = System.IO.Path.Combine(folderPath, "myfile3.txt");
            File.WriteAllText(filePath3, content3);


            // READING FILES

            // 4: read using StreamReader and ReadLine()
            List<string> lines4 = new List<string>();
            string filePath4 = System.IO.Path.Combine(folderPath, "myfile1.txt");
            using (StreamReader reader = File.OpenText(filePath4))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines4.Add(line);
                }
            } 

            // 5: read using File.ReadAllLines()
            string[] lines5;
            string filePath5 = System.IO.Path.Combine(folderPath, "myfile1.txt");
            lines5 = File.ReadAllLines(filePath5);

            // 6: read using StreamReader and ReadToEnd()
            string content6;
            string filePath6 = System.IO.Path.Combine(folderPath, "myfile1.txt");
            using (StreamReader reader = File.OpenText(filePath6))
            {
                content6 = reader.ReadToEnd();
            }

            // 7: read using File.ReadAllText()
            string content7;
            string filePath7 = System.IO.Path.Combine(folderPath, "myfile1.txt");
            content7 = File.ReadAllText(filePath7);

            Console.ReadKey();

        }
    }
}
