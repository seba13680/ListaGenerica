using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaGenericaCadenas = new List<string>();
            var listaGenericaNumeros = new List<int>();

            Random CadenaAlAzar = new Random();
            for (int i = 0; i < 10; i++)
            {
                string palabra = "";
                for (int j = 0; j < 10; j++)
                {
                    palabra += Convert.ToString((char)CadenaAlAzar.Next(65, 121));
                }
                
                listaGenericaCadenas.Add(palabra);
            }

            listaGenericaCadenas.Sort();

            foreach (var item in listaGenericaCadenas)
            {
                Console.WriteLine(item);
            }

            Random EnteroAlAzar = new Random();
            for (int i = 0; i < 10; i++)
            {
                int Entero = 0; 
                for (int j = 0; j < 10; j++)
                {
                    Entero += EnteroAlAzar.Next(1, 3000);
                }
                listaGenericaNumeros.Add(Entero);
            }

            listaGenericaNumeros.Sort();

            foreach (var item in listaGenericaNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
