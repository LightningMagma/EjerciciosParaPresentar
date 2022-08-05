using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPresentar
{
    internal class MenuSumayResta
    {
        public void SumayResta()
        {
            Operadores operadores = new Operadores();
            Variables variables = new Variables();
            Console.WriteLine("Ingrese un número");
            variables.V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            variables.V2 = double.Parse(Console.ReadLine());
            operadores.Resultado1 = variables.V1 + variables.V2;
            operadores.Resultado2 = variables.V2 - variables.V1;
            Console.WriteLine($"La suma de los números es {operadores.Resultado1}\nLa resta de los números es {operadores.Resultado2}");
            Console.ReadKey();
        }
    }
}
