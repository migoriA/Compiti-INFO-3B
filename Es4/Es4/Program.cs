using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            do
            {
                Console.WriteLine("Inserisci un numero da elevare");
                n=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il numero di volte da elevare");
                x=Convert.ToInt32(Console.ReadLine());
            } while (x<=0 || n<=0);
            Console.WriteLine();
            for(int i = 0; i < x; i++)
            {
                var ris = Math.Pow(n,i);
                Console.WriteLine(ris);
            }
            Console.ReadKey();
        }
    }
}
