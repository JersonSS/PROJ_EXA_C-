using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFundamentos
{
    internal class example04
    {
        public static void Main(string[] args)
        {
            //Condicionales multiple
            //example: ingrese un modelo de celular y mostrar el precio del aproximado.

            //VARIABLES
            double precio = 0.0;

            //ENTRADA
            Console.Write("Ingrese el modelo de celular: ");
            String celular = Console.ReadLine();

            //PROCESO
            switch (celular)
            {
                case "Samsung S24":
                    precio = 4000.00;
                    break;
                case "Xiaomi Note 13":
                    precio = 1000.00;
                    break;
                case "Iphone 15 pro max":
                    precio = 5000.00;
                    break;
                case "Motorola":
                    precio = 300.00;
                    break;
                case "LG":
                    precio = 160.00;
                    break;
                default:
                    precio = 0.0;
                    break;
            }

            //SALIDA
            Console.WriteLine("El precio del celular: S/{0}",precio);
            Console.ReadLine();
        }
    }
}
