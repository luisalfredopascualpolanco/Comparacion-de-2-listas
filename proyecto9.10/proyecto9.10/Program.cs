using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto9._10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] lista1 = new int[15];
                int[] lista2 = new int[15];
                int vuelta = 0;
                int numero, ValorLista1;
                Console.WriteLine("Esta es la 1ra lista, presione enter para iniciar: ");
                Console.ReadKey();
                while (vuelta<15)
                {
                    numero = vuelta + 1;
                    Console.Write("Introduce el valor #"+numero+": ");
                    lista1[vuelta] = int.Parse(Console.ReadLine());
                    vuelta++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Usted ha introducido un valor invalido");
                throw;
            }
        }
    }
}
