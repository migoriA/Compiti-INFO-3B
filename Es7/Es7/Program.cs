using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire la parola: ");
            string original = Convert.ToString(Console.ReadLine());
            string reversed = Reverse(original);
            Console.WriteLine($"La parola girata e' {reversed}");
            Console.ReadKey();
            
        }
        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
    }
}
