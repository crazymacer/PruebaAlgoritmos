using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class ChangeString
    {
        public string build(string palabra)
        {
            var abecedario = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            var resultado = "";

            var palabraArr = palabra.ToArray();

            foreach (var item in palabraArr)
            {
                bool esLetra = Char.IsLetter(item);                

                if (esLetra)
                {
                    bool esMayuscula = char.IsUpper(item);                    

                    if (esMayuscula)
                    {
                        resultado += Char.ToUpper(item.Equals('Z') ? 'A' : abecedario[abecedario.IndexOf(char.ToLower(item)) + 1]);
                    }
                    else
                    {
                        resultado += Char.ToLower(item).Equals('z') ? 'a' : abecedario[abecedario.IndexOf(char.ToLower(item)) + 1];
                    }
                }
                else
                {
                    resultado += item;
                }                
            }

            return resultado;

        }
    }
}
