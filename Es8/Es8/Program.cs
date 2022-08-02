using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            char car=' ';
            int cont = 0;
            Console.Write("Inserire una frase: ");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Inserire un carattere: ");
            car = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == car)
                {
                    cont++;
                }
            }

            Console.WriteLine($"Il carattere e' presente per {cont} volte");
            Console.ReadKey();
        }
    }
}
