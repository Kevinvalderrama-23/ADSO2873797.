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
           
            //Console.WriteLine("digite un numero");
            //int num1 = int.Parse(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine($"El numero {num1} es par ");
                
            //}
            //else
            //{
            //    Console.WriteLine($"El numero {num1} es impar");
            //}

            //Console.ReadKey();


            Console.WriteLine(" A continuación vamos a crear un algoritmo de suma o resta, digite 1 si es suma, o 2 si es resta ");

            int numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Es una suma");
                Console.WriteLine("Digite el primer numero");

                int num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero");

                int num4 = int.Parse(Console.ReadLine());


                int resultado = num3 + num4;

                Console.WriteLine($"El resultado es {resultado}");

            }
            if (numero == 2)
            {
                Console.WriteLine("Es una resta");
                Console.WriteLine("Digite el primer numero");

                int num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el segundo numero");

                int num4 = int.Parse(Console.ReadLine());

                int resultado = num3 - num4;

                Console.WriteLine($"El resultado es {resultado}");
            }


            Console.ReadKey();


        }
    }
}
