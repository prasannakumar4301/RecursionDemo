using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionDemo
{
    internal class Program
    {
        static void Numbers(int n)
        {
            if (n > 0)
            {
                Numbers(n - 1);
                Console.Write(n + " ");
            }
            
        }
        static void Main(string[] args)
        {
            int n = 100;
            Numbers(n);
            Console.ReadKey();
            

        }
    }
}
