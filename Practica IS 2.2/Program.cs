using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_IS_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsMenu menu = new ClsMenu();

            menu.MostrarMenu();

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    menu.Cobrar(270);
                    break;
                case "b":
                    menu.Cobrar(230);
                    break;
                case "c":
                    menu.Cobrar(290);
                    break;
                default:
                    Console.WriteLine(opcion + " No es una opcion valida. pulse enter para continuar");
                    Console.ReadLine();
                    menu.MostrarMenu();
                    break;
            }

        }
    }
}
