/*Calculadora de descuentos - Según el monto de compra aplicar descuentos escalonados: 5%
(L500-999), 10% (L1000-2499), 15% (L2500+). Mostrar precio original, descuento y precio final.*/


namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
   /*pido el monto de la compra valido que sea positivo determino el porcentaje de descuento escalonado mediante condicionales y calculo el precio final*/
   public class Ejercicio17
    {
        public void CalcularDescuento()
        {
            Console.WriteLine("=== Ejercicio 17: Calculadora de descuentos ===");
            double monto = Convert.ToDouble(Console.ReadLine());

            if(monto <= 0)
            {
                Console.WriteLine("ERROR: El monto de la compra debe ser un numero mayor a 0");
                return;
            }

            double porcentaje;

            if (monto >= 2500)
            {
                porcentaje = 15;
            }
            else if (monto >= 1000)
            {
                porcentaje = 10;
            }
            else if (monto >= 500)
            {
                porcentaje = 5;
            }
            else
            {
                porcentaje = 0;
            }

            double descuento = monto * (porcentaje / 100.0);
            double precioFinal = monto - descuento;

            Console.WriteLine("\n--- Resumen de Compra ---");
            Console.WriteLine($"Precio original: L {monto:F2}");
            Console.WriteLine($"Descuento ({porcentaje}%): L {descuento:F2}");
            Console.WriteLine($"Precio final: L {precioFinal:F2}");
        }
    }
}