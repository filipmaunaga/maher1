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
            //program that returns a sum of n numbers(example: n = 10):
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;

            //}
            //Console.WriteLine("Sum is equal to: {0}", sum);
            //Console.ReadKey();

            //method that returns the larger value of two numbers
            //Program find = new Program();
            //int result = find.FindMax(64, 16);
            //Console.WriteLine("The larger number is: {0}", result);
            //Console.ReadKey();
            //method that is a simple calculator
            //Program calculator = new Program();
            //Console.WriteLine("Enter the first number: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the operation: ");
            //string o = (Console.ReadLine());
            //double result = calculator.SimpleCalculator(a, b, o);
            //Console.WriteLine("The result is: {0} {1} {2}={3}", a, o, b, result);
            //Console.ReadKey();
            //Console.WriteLine("Factorial of 8 is {0}", Factorial(8));
            //Console.ReadKey();
            //Console.WriteLine("Enter the first number: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Modify(ref a, ref b);
            //Console.WriteLine("New values are: a={0} b={1}", a, b);
            //Console.ReadKey();
            //double k, f = 0;
            //Console.WriteLine("Enter the temperature in Celsius:");
            //double t = Convert.ToDouble(Console.ReadLine());
            //TemperatureConverter(t, out k, out f);
            //Console.ReadKey();
            //Console.WriteLine("Enter the desired number:");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int s = SumOfCharacters(k);
            //Console.WriteLine("The sum of characters for number {0} is {1}", k, s);
            //Console.ReadKey();
            //Console.WriteLine("Enter the desired number:");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int s = SumOfEven(k);
            //Console.WriteLine("The sum of even numbers before {0} is {1}", k, s);
            //Console.ReadKey();





        }
        public int FindMax(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
        public double SimpleCalculator(double a, double b, string o)
        {
            double result;
            switch (o)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    result = 0;
                    break;
            }
            return result;
        }
        static int Factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }
        static void Modify(ref int a, ref int b)
        {
            int r1 = a * 10;
            a = r1;
            int r2 = b + 2;
            b = r2;

        }
        static void TemperatureConverter(double t,out double k, out double f)
        {
            
            k = t + 273.15;
            f = t * 1.8 + 32;
            Console.WriteLine("Temperature converted to K is {0}", k);
            Console.WriteLine("Temperature converted to F is {0}", f);
        }

        static int SumOfCharacters(int k)
        {
            int sum = 0;
            string l = Convert.ToString(k);
            for (int i=0; i < l.Length; i++)
            {
                sum = sum + Convert.ToInt32(l.Substring(i, 1));
            }
            return sum;
        }

        static int SumOfEven(int k)
        {
            int sum = 0;
            
            for (int i = 0; i < k; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
                

            }
            return sum;
        }    


    }
}
