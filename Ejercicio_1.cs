using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_al_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 2;
            while (contador <= 20)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
            Console.ReadLine();
        }
    }
}


