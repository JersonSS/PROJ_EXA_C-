using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProveedorBE
    {
        public ProveedorBE() { }

        public ProveedorBE(decimal idProveedor, string nombre, string representante, string direccion, string ciudad, string departamento, string codigoPostal, string telefono, string fax)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Representante = representante;
            Direccion = direccion;
            Ciudad = ciudad;
            Departamento = departamento;
            CodigoPostal = codigoPostal;
            Telefono = telefono;
            Fax = fax;
        }

        public decimal IdProveedor { get; set; }

        public string Nombre { get; set; }

        public string Representante { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Departamento { get; set; }

        public string CodigoPostal { get; set; }

        public string Telefono { get; set; }

        public string Fax { get; set; }
    }
}
