using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire un valore: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            inputVet(v);
            var aus=calcolaSimmetria(v);
            stampaVet(aus);
            Console.ReadKey();
        }
        private static void inputVet(int[] v)
        {
            for(int i = 0; i < v.Length; i++)
            {
                Console.Write("Inserire i valori dei vettori: ");
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int[] calcolaSimmetria(int[] v)
        {
            int j = v.Length-1;
            int[] aus = new int[v.Length%2==0 ? v.Length/2 : (v.Length+1)/2];
            for(int i = 0; i < v.Length/2; i++)
            {
                if (v.Length % 2 == 0)
                {
                    aus[i] = v[i] * v[j];
                }
                j--;
            }
            return aus;
        }
        private static void stampaVet(int[] v)
        {
            for(int i= 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
