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

            Datos cliente = new Datos("CEDEÑO SÁNCHEZ", "ECKERD Gabriel", 0958156945, "GUAYAQUIL");
            DatosGasolina GasE = new DatosGasolina("Extra", 1, 1.50);
            

            Datos cliente2 = new Datos("GUTIERREZ SALAVARRIA", "LINDA VERÓNICA", 0969346721, "GUAYAQUIL");
            DatosGasolina GasS = new DatosGasolina("Super", 1, 2.00);

            Console.WriteLine("**** Datos del Primer Cliente ****");
            Console.WriteLine("Apellido: {0}, Nombre: {1}, N° cédula: {2}, Dirección: {3}",
                    cliente.Apellido, cliente.Nombres, cliente.Num_Cedula, cliente.Direccion);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("<== Datos de las gasolina ==>");
            Console.WriteLine("Tipo: {0}, Galones: {1}, Precio: {2}",
                    GasE.Tipo, GasE.CantidadxG, GasE.PrecioDeVenta);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("<== TOTAL FACTURA ==>    ");
            Console.WriteLine("     Subtotal:     " + GasE.Subtotal);
            Console.WriteLine("     Iva 12%:      " + GasE.ImpuestoIVA);
            Console.WriteLine("     Total:  " + GasE.TotalFactura);
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("FIN DE LA FACTURA.");



            Console.WriteLine("**** Datos del Segundo Cliente ****");
            Console.WriteLine("Apellido: {0}, Nombre: {1}, N° cédula: {2}, Dirección: {3}",
                    cliente2.Apellido, cliente2.Nombres, cliente2.Num_Cedula, cliente2.Direccion);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("<== Datos de las gasolina ==>");
            Console.WriteLine("Tipo: {0}, Galones: {1}, Precio: {2}",
                    GasS.Tipo, GasS.CantidadxG, GasS.PrecioDeVenta);
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("<== TOTAL FACTURA ==>    ");
            Console.WriteLine("     Subtotal:     " + GasS.Subtotal);
            Console.WriteLine("     Iva 12%:      " + GasS.ImpuestoIVA);
            Console.WriteLine("     Total:  " + GasS.TotalFactura);
            Console.WriteLine("---------------------------------------------------------- ");
            Console.WriteLine("FIN DE LA FACTURA");
            Console.ReadKey();
        }
    }
}
