using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPresentar
{
    internal class Dados:Metodos
    {
        public void Lanzar()
        {
            int i;
            do
            {
                Console.Clear();
                Console.WriteLine("Oprima 1 para seguir lanzando los dados. Para finalizar oprima 2");
                aleatorio();
                imprimirValores();
                imprimirResultado();
                i = int.Parse(Console.ReadLine());
            } while (i == 1);
            Console.Read();
        }
    }
}
