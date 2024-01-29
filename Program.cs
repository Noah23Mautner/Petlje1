using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYear = 1900;
            int endYear = 2100;

            Console.WriteLine("Prijestupne godine u razdoblju od {0} do {1} su:", startYear, endYear);

            for (int year = startYear; year <= endYear; year++)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine(year);
                }

            }
            Console.ReadKey();  
        }
    }
}
