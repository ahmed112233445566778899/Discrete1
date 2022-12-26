using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class program
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n1, n2;

                Console.WriteLine("enter your first number :");
                n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter your second number :");
                n2 = int.Parse(Console.ReadLine());

                for (int i = n1; i <= n2; i++)
                {
                    bool prime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                            prime = false;
                    }
                    if (prime == true)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
