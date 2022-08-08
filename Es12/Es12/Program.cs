using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire un numero: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] bin=new int[10];
            int i = 0;

            while (n != 0)
            {
                if (n % 2 == 0)
                {
                    bin[i] = 0;
                }
                else
                {
                    bin[i] = 1;
                }
                n /= 2;
                i++;
            }
            for(int j = i; j >= 0; j--)
            {
                Console.Write(bin[j]);
            }
            Console.ReadKey();
        }
    }
}
