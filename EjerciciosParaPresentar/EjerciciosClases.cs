using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosParaPresentar
{
    internal class EjerciciosClases
    {
        public void Menu()
        {
            Dados dados = new Dados();
            Operadores operados = new Operadores();
            MenuSumayResta menuSumayResta = new MenuSumayResta();
            Console.WriteLine("Se encuentra en el menú de Clases. Digite el punto que desea ver:");
            Console.WriteLine("1. Primer Punto");
            Console.WriteLine("2. Segundo Punto");
            Console.WriteLine("3. Tercer Punto");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    dados.Lanzar();
                    break;
                case 2:
                    //SegundoMetodo();
                    break;
                case 3:
                    //operados.Sumar();
                    //operados.Restar();
                    menuSumayResta.SumayResta();
                    break;
                default:
                    break;
            }
        }
    }
}
