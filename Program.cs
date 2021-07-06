using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pregunta 01
            var changeString = new ChangeString();
            var palabra = "123 abcd*3";
            var resultado = changeString.build(palabra);
            Console.WriteLine("---- PREGUNTA 01 ----");
            Console.WriteLine($"Entrada: {palabra}");
            Console.WriteLine($"Salida: {resultado}");
            
            Console.WriteLine("");
            Console.WriteLine("");

            // Pregunta 02
            Console.WriteLine("---- PREGUNTA 01 ----");
            var numeros = new List<int> { 1,2,3,4, 5,6,7, 8, 3 };
            var OrderRange = new OrderRange();
            OrderRange.build(numeros);
            Console.ReadLine();

        }
    }
}
