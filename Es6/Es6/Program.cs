using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dado=0;
            Random rnd = new Random();

            do
            {
                dado = rnd.Next(0, 7);
                if (dado != 0)
                {
                    Console.WriteLine(dado);
                }
            } while (dado!=0);
            
            Console.ReadKey();
        }
    }
}
