using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPresentar
{
    internal class Metodos
    {
        int d1, d2, d3;
        public void imprimirResultado()
        {
            if (d1 == d2 && d2 == d3)
            {
                Console.WriteLine("Has ganado, felicidades");
            }
            else
            {
                Console.WriteLine("Lo sentimos, has perdido");
            }

        }
        public void imprimirValores()
        {
            Console.WriteLine("Dado 1 :" + d1);
            Console.WriteLine("Dado 2 :" + d2);
            Console.WriteLine("Dado 3 :" + d3);
        }
        public void aleatorio()
        {
            Random rand = new Random();
            d1 = rand.Next(1, 7);
            d2 = rand.Next(1, 7);
            d3 = rand.Next(1, 7);
        }
    }
}
