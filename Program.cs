using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        public static decimal i { get; private set; }

        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("please enter your first number :");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your last number :");
            n2 = int.Parse(Console.ReadLine());

            for (int num = n1; num < n2; num++)
            {
                decimal sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum = sum + i;
                }
                if (sum == num)
                {
                    Console.WriteLine(num);
                }

            }
        
            }
        }
    }

