using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número:");
            int num = Convert.ToInt16(Console.ReadLine());
            int cant=0;

            for (int i = Convert.ToInt16(num); i >= 1; i--)
            {
                if ((num % i) == 0)
                {
                  cant++;
                }
            }

            if (cant == 2)
            {
                Console.WriteLine("El número {0} es primo", num);                
            }
            else
            Console.WriteLine("El número {0} no es primo", num);
            Console.ReadKey();
        }
    }
}
