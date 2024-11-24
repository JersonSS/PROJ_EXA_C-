using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFundamentos
{
    internal class example03
    {
        public static void Main(string[] args)
        {
            //Condicionales IF-ELSE
            //example: Ingrese la edad de una persona y verifique si puede votar en unas elecciones.

            //VARIABLES
            String mensaje = "null";

            //ENTRADA
            Console.Write("Ingrese la edad de la persona: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            //PROCESO
            if (edad >= 18)
            {
                mensaje = "Puede votar en las elecciones.";
            }
            else
            {
                mensaje = "No puede votar en las elecciones.";
            }

            //SALIDA
            Console.WriteLine("Mensaje: {0}", mensaje);
            Console.ReadLine();
            //Console.WriteLine("toque cualquier tecla");
            //Console.ReadKey();
        }
    }
}
