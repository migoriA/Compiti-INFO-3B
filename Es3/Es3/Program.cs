using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire un'ora con il , da separatore: ");
            decimal ora = Convert.ToDecimal(Console.ReadLine());
            string[] sep = new string[2];
            sep = ora.ToString().Split(',');

            int ore = Convert.ToInt32(sep[0]);
            int minuti= Convert.ToInt32(sep[1]);
            int secondi = (ore * 3600) + (minuti * 60);
            Console.Write($"\nCi sono {secondi} in {ora}");
            Console.ReadLine();
        }
    }
}
