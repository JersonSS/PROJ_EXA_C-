using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFundamentos
{
    internal class problema01
    {
        public static void Main(string[] args)
        {
            //VARIABLES
            double asignacion= 0.0;

            //ENTRADA
            Console.Write("Ingrese cuanto hijos tiene: ");
            int nro_hijos = Convert.ToInt32(Console.ReadLine());

            //PROCESO


            if (nro_hijos == 0)
            {
                asignacion = 0.0;

            }
            else if(nro_hijos==1)
            {
                asignacion = 50.0;
            }
            else if(nro_hijos==2)
            {
                asignacion = 75.0;
            }
            else if (nro_hijos >= 3)
            {
                asignacion = 100.0;
            }

            //SALIDA
            Console.WriteLine("La asignacion familiar es: S/{0}", asignacion);
            Console.ReadLine();



        }
    }
}
