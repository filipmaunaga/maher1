using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maher1
{
    class Program
    {
        static void Main(string[] args)
        {
            program that returns a sum of n numbers(example: n = 10):
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Sum is equal to: {0}", sum);
            Console.ReadKey();



        }
    }
}
