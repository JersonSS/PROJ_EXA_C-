using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GeneroBE
    {
        public GeneroBE(){}

        public GeneroBE(string descripcion)
        {
            Descripcion = descripcion;
        }

        public GeneroBE(int iD, string descripcion)
        {
            ID = iD;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }

    }
}
