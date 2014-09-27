using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppnumeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int num;
            Console.WriteLine("Numero Positivo");
            Console.WriteLine("Digite un numero entre 1 y 99:  ");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            if(numero.Length<=2 && num>0)
            {
                Console.WriteLine("El Numero Es Positivo");
                if (numero.Length == 2)
                {
                    Console.WriteLine("El Numero Tiene Dos Digitos");
                }
                else
                {
                    Console.WriteLine("El Numero Tiene Un Digito");
                }
            }
            else
            {
                Console.WriteLine("El Numero Es Negativo");
            }
            Console.ReadKey();
        }
    }
}
