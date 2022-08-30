using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es17
{
    internal class Program
    {
        public struct Materie
        {
            public string materia;
            public int votoO;
            public int votoS;
            public int votoP;
        };

        static Materie[] mats = new Materie[8];

        static void Main(string[] args)
        {
            int scelta = 0;
            string materia = null;
            do
            {
                Console.Clear();
                scelta = menu();
                switch (scelta)
                {
                    case 1:
                        break;
                    case 2:
                        caricaMaterie();
                        break;
                    case 3:
                        caricaVoti();
                        break;
                    case 4:
                        Console.Write("Inserire una materia: ");
                        materia = Convert.ToString(Console.ReadLine());
                        calcolaMediaMateria(materia);
                        break;
                    case 5:
                        calcolaMediaTOT();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
            } while (scelta!=1);
            Console.ReadKey();
        }

        static int menu()
        {
            int sc;
            Console.WriteLine("1. esci");
            Console.WriteLine("2. carica materie");
            Console.WriteLine("3. carica voti");
            Console.WriteLine("4. visualizza la media della materia X");
            Console.WriteLine("5. visualizza la media totale");
            Console.WriteLine("6. visualizza le medie in ordine crescente, il min e il max");
            Console.Write("\nScelta -> ");
            sc = Convert.ToInt32(Console.ReadLine());
            return sc;
        }

        private static void caricaMaterie()
        {
            for(int i = 0; i < mats.Length; i++)
            {
                Console.Write("Inserire le materie: ");
                mats[i].materia = Convert.ToString(Console.ReadLine());
            }
        }

        private static void caricaVoti()
        {
            for(int i = 0; i < mats.Length; i++)
            {
                Console.Clear();
                Console.Write($"{mats[i].materia}\n");
                Console.Write("Inserire il voto orale: ");
                mats[i].votoO = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il voto scritto: ");
                mats[i].votoS = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserire il voto pratico: ");
                mats[i].votoP = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void calcolaMediaMateria(string materia)
        {
            float media = 0;
            
            for(int i = 0; i < mats.Length; i++)
            {
                if (mats[i].materia == materia)
                {
                    media = (mats[i].votoO + mats[i].votoS + mats[i].votoP)/3;
                }
            }
            Console.Write($"La media è {media}");
            Console.ReadKey();
        }

        public static void calcolaMediaTOT()
        {
            float media = 0;
            for(int i = 0; i < mats.Length; i++)
            {
                media += mats[i].votoO + mats[i].votoS + mats[i].votoP;
            }
            Console.Write($"Media totale {media / 24}");
            Console.ReadKey();
        }
    }
}
