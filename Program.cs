using System;

namespace mod3_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int importe;
            float totalPagar;

            Console.WriteLine("Ingrese el importe de la compra:");
            importe = int.Parse(Console.ReadLine());

            if (importe > 5000)
            {
                totalPagar = 
                Console.WriteLine("No hay descuento");
            }
        }
    }
}
