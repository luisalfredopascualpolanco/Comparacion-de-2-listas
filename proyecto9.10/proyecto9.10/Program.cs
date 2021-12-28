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
                int numero;
                int TotalLista1 = 0;
                int TotalLista2 = 0;

                Console.WriteLine("Esta es la 1ra lista, presione enter para iniciar: ");
                Console.ReadKey();
                
                while (vuelta<15)
                {
                    numero = vuelta + 1;
                    Console.Write("Introduce el valor #"+numero+": ");
                    lista1[vuelta] = int.Parse(Console.ReadLine());
                    vuelta++;
                }
                vuelta = 0;
                
                Console.WriteLine("Esta es la 2da lista, presione enter para iniciar: ");
                Console.ReadKey();
               
                while (vuelta < 15)
                {
                    numero = vuelta + 1;
                    Console.Write("Introduce el valor #" + numero + ": ");
                    lista2[vuelta] = int.Parse(Console.ReadLine());
                    vuelta++;
                }
                vuelta = 0;

                while (vuelta < 15)
                {
                    TotalLista1 = TotalLista1 + lista1[vuelta];
                    TotalLista2 = TotalLista2 + lista2[vuelta];
                    vuelta++;
                }

                if (TotalLista1>TotalLista2)
                {
                    Console.WriteLine("Lista 1 mayor");
                }
                else if(TotalLista2>TotalLista1)
                {
                    Console.WriteLine("Lista 2 mayor");
                }
                else
                {
                    Console.WriteLine("Listas iguales");
                }               
            }
            catch (Exception)
            {
                Console.WriteLine("Usted ha introducido un valor invalido");                
            }
            Console.ReadKey();
        }
    }
}
