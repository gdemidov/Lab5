using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Random random = new Random();
            int S = 0;
            int ms;
            for (int i = 0; i < 7; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
                S += array[i];
            }
            ms = S / 7;
            Console.WriteLine();
            Console.WriteLine("среднее арифмитическое = {0}", ms);
            Console.ReadKey();
        }
    }
}
