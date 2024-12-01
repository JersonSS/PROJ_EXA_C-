﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AutorBE
    {
        public AutorBE() { }

        public AutorBE( string apellido, string nombre, DateTime fechaNacimineto, int nacionalidad)
        {
            
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimineto = fechaNacimineto;
            Nacionalidad = nacionalidad;
        }

        public AutorBE(int iD, string apellido, string nombre, DateTime fechaNacimineto, int nacionalidad)
        {
            ID = iD;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimineto = fechaNacimineto;
            Nacionalidad = nacionalidad;
        }

        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimineto { get; set; } 
        public int Nacionalidad { get; set; }
    }
}