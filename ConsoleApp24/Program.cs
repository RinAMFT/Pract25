using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 3, -3, 5, 6, -7, 8 };
            //int[]omas=now int[] {3,-3,5,6,-7,8}
            foreach(var element in omas)
            {
                Console.WriteLine($"{element}\t");
            }
            Console.ReadKey();
        }
    }
}
