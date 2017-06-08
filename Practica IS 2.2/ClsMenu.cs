using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_IS_2._2
{
    public class ClsMenu
    {
        //int A = 270, B = 340, C = 390;

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine(
                "Producto A $270\n" +
                "Producto B $340\n" +
                "Producto C $390\n\n" +
                "Seleccione un producto");
                return;
        }   
        public void Cobrar(int precio)
        {
            Console.WriteLine("Introdusca cantidad: ");

            int saldo = Console.Read();

            if (saldo != 0)
            {

            }

        }
    }
}
