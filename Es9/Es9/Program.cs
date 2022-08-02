using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vet = new int[10];
            var rnd = new Random();

            for(int i = 0; i < vet.Length; i++)
            {
                vet[i]=rnd.Next(0,31);
            }
            sommaPosPariDispari(vet);
        }

        private static void sommaPosPariDispari(int[] vet)
        {
            int somP=0;
            int somD=0;
            var max = int.MinValue;
            var min = int.MaxValue;

            for(int i = 0; i < vet.Length; i++)
            {
                if (i % 2 == 0)
                    somP += vet[i];
                else
                    somD += vet[i];
                if (vet[i] > max)
                    max = vet[i];
                else if (vet[i]<min)
                    min = vet[i];
            }

            Console.WriteLine($"La somma dei numeri in posizione pari e' {somP}\nLa somma dei numeri in posizione dispari e' {somD}\nL'ampiezza dell'intervallo e' {max - min}");
            Console.ReadKey();
        }
    }
}
