﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero, num;
            Console.WriteLine("Programa que pasa de caracter a numero");
            Console.WriteLine("escriba numero de 1 a 5 en letras");
            numero = Console.ReadLine ();
            num = numero.ToUpper();
            switch(num)
        {
                case "UNO":
                Console.WriteLine("1");
                    break;
                case "DOS":
                Console.WriteLine("2");
                    break;
                case "TRES":
                Console.WriteLine("3");
                    break;
                case "CUATRO":
                Console.WriteLine("4");
                    break;
                case "CINCO":
                Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Numero fuera de rango");
                    break;
        }
            Console.ReadKey();
        }
    }
}
