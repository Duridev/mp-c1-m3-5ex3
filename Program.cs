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

            if (importe < 1000)
            {
                totalPagar = importe * 0,35;
                Console.WriteLine("No hay descuento");
            } else if (importe > 1000 && importe < 5000) {
                totalPagar = importe * 0,9;
                Console.WriteLine("Aplica un 10% de descuento");

            } else {
                totalPagar = importe * 0,82;
                Console.WriteLine("Aplica un 18% de descuento");
            }

            Console.WriteLine($"El total a pagar es de: ${totalPagar}");
        }
    }
}
