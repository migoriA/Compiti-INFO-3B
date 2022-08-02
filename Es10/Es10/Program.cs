using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vet1 = new int[10];
            var vet2 = new int[10];

            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                vet1[i] = rnd.Next(0, 11);
                vet2[i] = rnd.Next(0, 11);
            }
            verificaUgualita(vet1, vet2);
            Console.ReadKey();
        }
        /// <summary>
        /// Funzione che appena trova valori diversi all'interno dei vettori ritorna alla funzione chiamante
        /// </summary>
        /// <param name="vet1">Primo vettore</param>
        /// <param name="vet2">Secondo vettore</param>
        private static void verificaUgualita(int[] vet1, int[] vet2)
        {
            for(int i=0; i < vet1.Length; i++)
            {
                if (vet1[i] != vet2[i])
                {
                    Console.WriteLine("I vettori non sono uguali");
                    return;
                }
            }
            Console.WriteLine("I vettori sono uguali");
        }
    }
}
