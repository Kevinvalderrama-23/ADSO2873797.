using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("digite un numero");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"El numero {num1} es par ");
                
            }
            else
            {
                Console.WriteLine($"El numero {num1} es impar");
            }

            Console.ReadKey();

        }
    }
}
