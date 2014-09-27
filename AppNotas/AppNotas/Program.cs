using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Promedio de Notas");
            Console.WriteLine("Ingrese Nota 1:  ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 2:  ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 3:  ");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio >= 3.5)
                {
                    Console.WriteLine("Es promocionado");
                }
            else
            {
                Console.WriteLine("No es promocionado");
            }
            Console.ReadKey ();

        }

    }
}
