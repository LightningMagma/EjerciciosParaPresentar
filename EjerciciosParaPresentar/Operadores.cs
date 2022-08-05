using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPresentar
{
    internal class Operadores
    {
        double resultado;
        double resultado2;

        public double Resultado1 { get => resultado; set => resultado = value; }
        public double Resultado2 { get => resultado2; set => resultado2 = value; }

        public void Operar()
        {
            Console.WriteLine(Resultado1);
            Console.ReadKey();
        }
    }
}
