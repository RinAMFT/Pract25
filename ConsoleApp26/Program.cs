using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main()
        {
            int size = 10; 
            int[] mas = new int[size];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }
            foreach (int element in mas)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();  
        }
    }
}
