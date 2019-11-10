using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCedeno3B.clase
{
    class DatosGasolina
    {
        public DatosGasolina(string tipo, double cantidadxG, double precioDeVenta)
        {
            Tipo = tipo;
            CantidadxG = cantidadxG;
            PrecioDeVenta = preciodeventa;
        }
        private string tipo;
    
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private double cantidadxG;

        public double CantidadxG
        {
            get { return cantidadxG; }
            set { cantidadxG = value; }
        }
        private double preciodeventa;

        public double PrecioDeVenta
        {
            get { return preciodeventa; }
            set { preciodeventa = value; }
        }
        public double Subtotal
        {
            get { return preciodeventa * CantidadxG; }
        }

        public double ImpuestoIVA
        {
            get { return Subtotal * 0.12; }
        }

        public double TotalFactura
        {
            get { return Subtotal + ImpuestoIVA; }
        }
    }
}

    

