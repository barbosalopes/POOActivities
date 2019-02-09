using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POOActivities
{
    static class ConsoleInterface
    {
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static double GetDouble(string errorMessage)
        {
            double n;
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(errorMessage);
            }
            return n;
        }

        public static int GetInt(string errorMessage)
        {
            int n;
            string s;
            Regex rgx = new Regex("^[0-9]+$");

            s = Console.ReadLine();
            while ((!int.TryParse(s, out n) && !rgx.IsMatch(s)) || n < 0)
            {
                Console.WriteLine(errorMessage);
                s = Console.ReadLine();
            }
            return n;
        }

        public static string GetString()
        {
            return Console.ReadLine();
        }

        public static string GetChar()
        {
            return Console.ReadLine();
        }
    }
}
