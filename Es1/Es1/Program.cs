using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            do
            {
                Console.Write("Inserire un valore: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire un secondo valore: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (x <= 0 || n <= 0);
            for (int i = 0; i < n; i++)
            {
                var ris = x * i;
                Console.Write(x + "*" + i + "=" + ris + "\n");
            }
            Console.ReadKey();
        }
    }
}
