using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleGenerateShiftsCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            // generate shifts
            int numHairdressers = 100;
            int numSalons = 6;
            int numWeekdays = 6;
            Random rnd = new Random();
            string csvContent = "";

            for (int i = 1; i <= numHairdressers; i++)
            {
                // generate default salon
                int defaultSalon = rnd.Next(1, numSalons);
                for (int j = 1; j <= numWeekdays; j++)
                {
                    if (rnd.Next(1, 5) == 1) continue;
                    int salon = rnd.Next(1, 10) == 1 ? rnd.Next(1, 6) : defaultSalon;
                    int starthour = rnd.Next(9, 13);
                    int endhour = rnd.Next(starthour + 1, 18);
                    csvContent += $"{i};{salon};{j};{starthour}:00;{endhour}:00{Environment.NewLine}";
                }
            }

            // write to csv
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = System.IO.Path.Combine(folderPath, "shifts.csv");

            // open stream and start writing
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(csvContent);
            }

            // ok
            Console.WriteLine("csv generated");
            Console.ReadKey();
        }
    }
}
