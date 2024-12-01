using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PaisBE
    {
        public PaisBE(){}

        public PaisBE(string descripcion)
        {
            Descripcion = descripcion;
        }

        public PaisBE(int iD, string descripcion)
        {
            ID = iD;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public String Descripcion { get; set; }
    }
}
