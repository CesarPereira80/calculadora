using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Introduça um número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduça um segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quê operaçao pretende realizar? As opções são: adição (1), resta (2), multiplicação (3) ou divisão (4)");
            char operador = (char)Console.Read();
            double resultado;
            switch (operador)
            {
                case '1':
                    resultado = num1 + num2;
                    break;
                case '2':
                    resultado = num1 - num2;
                    break;
                case '3':
                    resultado = num1 * num2;
                    break;
                case '4':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            Console.WriteLine($"O resultado da operação {num1} {operador} {num2} é {resultado}");
        }

    }


    }



