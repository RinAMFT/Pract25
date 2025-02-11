using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] omas = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"mas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"mas[{i}]={omas[i]}");
            }
            //Console.Write("n=");
            //int n= int.Parse(Console.ReadLine());
            //int[] omas = new int[n];
            //for (int i = 0; i< n; i++)
            //{
            //    Console.Write($"mas[{i}]=");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0;i< n; i++)
            //{
            //    Console.WriteLine($"mas[{i}]={omas[i]}");
            //}
            Console.ReadKey();
        }
    }
}
