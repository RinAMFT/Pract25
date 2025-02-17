using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        /// <summary>
        /// Task4 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] mas = new int[6];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                //Console.WriteLine($"mas[{i}]=");
                mas[i] = random.Next(-10,10);
            }
            foreach (var element in mas)
            {
                Console.Write($"{element}\t");
            }
            Console.ReadKey();
        }
    }
}
