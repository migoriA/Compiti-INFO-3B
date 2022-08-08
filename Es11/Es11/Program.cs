using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[4];

            for(int i = 0; i < chars.Length; i++)
            {
                Console.Write("Inserire un carattere: ");
                chars[i]=Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            }

            if (verificaSeOrdinato(chars))
                Console.Write("E' ordinato");
            else
                Console.Write("Non e' ordinato");

            Console.ReadKey();
        }
        /// <summary>
        /// Funzione simile all'ordinamento per scambio ma modificata per verificare se il vettore e' ordinato
        /// </summary>
        /// <param name="arg"> Vettore da verificare </param>
        /// <returns></returns>

        private static bool verificaSeOrdinato(char[] arg)
        {
            int posMin;
            int cont=0;
            for(int i = 0; i < arg.Length - 1; i++)
            {
                posMin= i;
                for(int j = i + 1; j < arg.Length; j++)
                {
                    if (arg[posMin] > arg[j])
                        posMin = j;
                }
                if(posMin != i)
                {
                    cont++;
                }
            }

            if (cont == 0)
                return true;
            else
                return false;

        }
    }
}
