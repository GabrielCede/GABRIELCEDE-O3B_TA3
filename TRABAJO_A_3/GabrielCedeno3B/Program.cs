using System;
using GabrielCedeno3B.clase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCedeno3B
{
    class Program
    {
        static void Main(string[] args)
        {

            Datos primercliente = new Datos("CEDEÑO SÁNCHEZ", "ECKERD GABRIEL", 0958156945, "GUAYAQUIL");
            DatosGasolina GasE = new DatosGasolina("Extra", 1, 1.50);
            

            Datos segundocliente = new Datos("GUTIERREZ SALAVARRIA", "LINDA VERÓNICA", 0969346721, "GUAYAQUIL");
            DatosGasolina GasS = new DatosGasolina("Super", 1, 2.00);

            Console.WriteLine("=========================================================");
            Console.WriteLine("************** Datos del Primer Cliente *****************");
            Console.WriteLine("=========================================================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("APELLIDOS:" + primercliente.Apellido);
            Console.WriteLine("NOMBRES  :"+ primercliente.Nombres);
            Console.WriteLine("CÉDULA   :" + primercliente.Num_Cedula);
            Console.WriteLine("DIRECCIÓN:" + primercliente.Direccion);
           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=========================================================");
            Console.WriteLine("=========================================================");
            Console.WriteLine("");
            Console.WriteLine("<== Datos de las gasolina ==>");
            Console.WriteLine("Tipo: {0}, Galones: {1}, Precio: {2}",
                    GasE.Tipo, GasE.CantidadxG, GasE.PrecioDeVenta);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" ************TOTAL FACTURA**********   ");
            Console.WriteLine("     Subtotal    :     " + GasE.Subtotal);
            Console.WriteLine("     Iva 12%     :     " + GasE.ImpuestoIVA);
            Console.WriteLine("     Total       :     " + GasE.TotalFactura);
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("");
            Console.WriteLine("FIN DE LA FACTURA.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("=========================================================");
            Console.WriteLine("************* Datos del Segundo Cliente *****************");
            Console.WriteLine("=========================================================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("APELLIDOS:" + segundocliente.Apellido);
            Console.WriteLine("NOMBRES  :" + segundocliente.Nombres);
            Console.WriteLine("CÉDULA   :" + segundocliente.Num_Cedula);
            Console.WriteLine("DIRECCIÓN:" + segundocliente.Direccion);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=========================================================");
            Console.WriteLine("=========================================================");
            Console.WriteLine("");

            Console.WriteLine("<== Datos de las gasolina ==>");
            Console.WriteLine("Tipo: {0}, Galones: {1}, Precio: {2}",
                    GasS.Tipo, GasS.CantidadxG, GasS.PrecioDeVenta);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine(" ************TOTAL FACTURA**********   ");
            Console.WriteLine("     Subtotal:     " + GasS.Subtotal);
            Console.WriteLine("     Iva 12% :     " + GasS.ImpuestoIVA);
            Console.WriteLine("     Total   :     " + GasS.TotalFactura);
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("FIN DE LA FACTURA");
            Console.ReadKey();
        }
    }
}

