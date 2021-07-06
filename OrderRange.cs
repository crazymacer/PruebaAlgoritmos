using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class OrderRange
    {
        public void build(List<int> numeros)
        {
            var pares = new List<int>();
            var impares = new List<int>();

            foreach (var item in numeros)
            {
                var esPar = item % 2 == 0;

                if (esPar)
                {
                    pares.Add(item);
                }
                else
                {
                    impares.Add(item);
                }
            }

            pares = pares.OrderBy(q => q).ToList();
            impares = impares.OrderBy(q => q).ToList();


            // Salida
            var entradaArr = "Entrada: [ " + String.Join(",", numeros) + "]";
            Console.WriteLine(entradaArr);
                        
            var paresStr = "Pares: [" + String.Join(",", pares) + "]";
            Console.WriteLine(paresStr);
                        
            var imparesStr = "Impares: [" + String.Join(",", impares) + "]";
            Console.WriteLine(imparesStr);

        }
    }
}
