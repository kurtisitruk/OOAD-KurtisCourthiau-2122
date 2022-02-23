using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // karakters trimmen aan het begin en einde
            string str1 = "  ,Guitar, drum, Bass,. ";
            str1 = str1.Trim(); // ",Guitar, drum, Bass,."
            str1 = str1.Trim(new char[] { ',', '.' }); // "Guitar, drum, Bass"

            // posities van karakters
            string str2 = "Now have that tasty morning burger.";
            int len = str2.Length; // 35
            int int1 = str2.IndexOf('a'); // 5
            int int2 = str2.IndexOf('z'); // -1; not found
            int int3 = str2.LastIndexOf('e'); // 32
            bool bool1 = str2.StartsWith("No"); // true

            // bewerkingen
            string str3 = "Oh please DO NOT touch that!";
            str3 = str3.ToLower(); // "oh please do not touch that!"
            str3 = str3.Substring(0, 12); // "oh please do"

            // string array
            string[] regels = {
                "Comfort reached gay perhaps chamber his six detract besides add!",
                "Moonlight newspaper up he it enjoyment agreeable depending?",
                "She her rapturous suffering concealed"
            };
            // glue together around newlines
            string tekst = String.Join(Environment.NewLine, regels);
            Console.WriteLine(tekst);

            // split around spaces
            Console.WriteLine("Deze tekst bevat {0} woorden", tekst.Split(' ').Length);

            // split around character list
            Console.WriteLine("Tekst bevat {0} zinsdelen", tekst.Split(new char[] { '?', '!', ',', '.', ';' }).Length);
            Console.ReadKey();

            // string splitsen in array
            string str4 = "C:/Rogier/My Documents/test.txt";
            string[] parts = str4.Split(new char[] { '/' }); // { "C:", "Rogier", "My Documents", "test.txt“ }

            // array samenvoegen tot string
            string[] arr1 = new string[] { "blauw", "rood", "groen" };
            string str5 = String.Join(", ", arr1); // blauw, rood, groen"
        }
    }
}
