using System;

namespace mod3_ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            float totalPagar, importe;

            Console.WriteLine("Ingrese el importe de la compra:");
            importe = float.Parse(Console.ReadLine());

            if (importe < 1000){
                totalPagar = importe * 0.35f;
                Console.WriteLine("No hay descuento");
            } else if (importe >= 1000 && importe < 5000) {
                totalPagar = importe * 0.9f;
                Console.WriteLine($"Aplica un 10% de descuento: ${importe - totalPagar}");

            } else {
                totalPagar = importe * 0.82f;
                Console.WriteLine($"Aplica un 18% de descuento: ${importe - totalPagar}");
            }
            totalPagar = (float)Math.Round(totalPagar);
            Console.WriteLine($"El total a pagar es de: ${totalPagar}");
        }
    }
}
