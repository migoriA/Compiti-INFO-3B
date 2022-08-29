using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es14
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int n, m;
            
            Console.WriteLine("Inseire il numero delle righe: ");
            n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inseire il numero delle colonne: ");
            m = Convert.ToInt32(Console.ReadLine());

            var mat = new int[n, m];
            caricaMat(mat);
            var min = getMin(mat);
            var max = getMax(mat);
            Console.WriteLine($"Il valore minimo e' {min}\nIl valore massimo e' {max}");

            Console.ReadKey();

        }
        static void caricaMat(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j=0;j<m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 101);
                }
            }
        }

        static int getMin(int[,] m)
        {
            int min = int.MaxValue;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    min = min > m[i, j] ? m[i, j] : min;
                }
            }
            return min;
        }

        static int getMax(int[,] m)
        {
            int max = int.MinValue;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    max = max < m[i, j] ? m[i, j] : max;
                }
            }
            return max;
        }
    }
}
