using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of cases: ");
            int n = int.Parse(Console.ReadLine());
            int[] cases = new int[n];
            int a, b, c;
            int sum;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter 3 number: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                cases[i] = a * b + c;
            }
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                do
                {
                    sum += cases[i] % 10;
                    cases[i] = cases[i] / 10;
                }
                while (cases[i] > 0);
                Console.WriteLine($"Sum of Digits: {sum}");
            }
            Console.ReadKey();
        }
    }
}
