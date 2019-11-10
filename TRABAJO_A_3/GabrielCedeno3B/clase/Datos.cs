using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCedeno3B.clase
{
         class Datos
    {
        public Datos(string apellido, string nombre, int id, string direccion)
        {
            Apellido = apellido;
            Nombres = nombres;
            Num_Cedula = num_cedula;
            Direccion = direccion;
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private int num_cedula;

        public int Num_Cedula
        {
            get { return num_cedula; }
            set { num_cedula = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
