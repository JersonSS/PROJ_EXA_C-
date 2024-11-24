using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFundamentos
{
    internal class example07
    {
        public static void Main(string[] args)
        {
            //do-while (hacer mientras)
            //example: se tiene 10 sueldos aleatorios (rango 1025-2000)
            //se pide mostrar el sueldo promedio, minimos y maximos.

            //VARIABLES
            int cont;
            int min = 1025;
            int max = 5000;
            int suma = 0;
            int promedio = 0;

            int minn = 5000;
            int maxx = 1025;

            //ENTRADA

            //PROCESO
            var random = new Random(Environment.TickCount);

            for (cont = 1; cont <= 10; cont++)
            {
                //Random rnd = new Random();
                int sueldo = random.Next(min, max + 1);
                Console.WriteLine("Sueldo {0}: S/{1}", cont, sueldo);

                suma = suma + sueldo;

                minn = Math.Min(minn, sueldo);
                maxx = Math.Max(maxx, sueldo);


                cont++;
            }
            

            promedio = suma / (cont - 1);

            //SALIDA
            Console.WriteLine("El sueldo promedio es: S/{0}", promedio);
            Console.WriteLine("El sueldo minimo es: S/{0}", minn);
            Console.WriteLine("El sueldo maximo es: S/{0}", maxx);

            Console.ReadLine();

        }
    }
}