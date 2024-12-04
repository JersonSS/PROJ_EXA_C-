using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EditorialBE
    {
        public EditorialBE(){}

        public EditorialBE(string descripcion)
        {
            Descripcion = descripcion;
        }

        public EditorialBE(int iD, string descripcion)
        {
            ID = iD;
            Descripcion = descripcion;
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
