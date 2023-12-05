using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Masivi_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 21); 
            }

            Console.WriteLine("Sākotnējais masīvs:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"mas[{i + 1}] = {mas[i]}");
            }

            Console.WriteLine("\n\nApgrieztais masīvs:");
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"mas[{i + 1}] = {mas[i]}");

            }
        }
    }
}
