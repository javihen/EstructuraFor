using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listar 5 numeros aleatorios.
            int n;
             for(int i = 0; i < 5; i++)
             {
                 Random r = new Random();
                 n = r.Next(1, 10);
                 Console.WriteLine(n);

             }
             //Listar los divisores de un determinado numero entero.
            Console.WriteLine("INGRESE UN NUMERO CUALQUIERA");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("\t" + i);
                }
            }

            Console.ReadKey();
        }
    }
}
