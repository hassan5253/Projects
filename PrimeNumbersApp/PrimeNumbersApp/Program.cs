using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            a = Int32.Parse(Console.ReadLine());
            for (b=2; b < a; b++)
            {
                if (a % b == 0)
                { break; }
            }

                    if (a == b)
                    {
                        Console.WriteLine("It is PrimeNumber...");
                    }

                    else
                    {
                        Console.WriteLine("It is Not a PrimeNumber...");
                    }
                
            

        }
    }
}
