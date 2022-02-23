using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            string answer = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(answer);
                Console.WriteLine("het omgekeerde is {0}", 1 / number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("het getal heeft niet het juiste formaat");
            }
            catch (Exception e)
            {
                Console.WriteLine("een fout van het type {0} is op getreden: {1}", e.GetType(), e.Message);
            }
            finally
            {
                Console.WriteLine("druk een toets om verder te gaan...");
                Console.ReadKey();
            }
        }
    }
}
