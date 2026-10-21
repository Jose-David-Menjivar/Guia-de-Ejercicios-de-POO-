/*Calculadora de préstamo simple - Solicitar monto, tasa de interés anual y plazo en meses.
Calcular el interés total y la cuota mensual fija.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido el monto la tasa anual y el plazo en meses valido que sean positivos 
    y calculo el interes total junto con la cuota mensual fija usando interes simple*/
    public class Ejercicio10
    {
        public void CalcularPrestamo()
        {
            Console.WriteLine("=== Ejercicio 10: Prestamo simple ===");

            Console.Write("Ingrese el monto del prestamo (L) : ");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tasa de interés anual (%) : ");
            double tasaAnual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el plazo en meses : ");
            int meses = Convert.ToInt32(Console.ReadLine());

            if(monto <= 0 || tasaAnual <= 0 || meses <= 0)
            {
                Console.WriteLine("ERROR: todos los valores deben ser mayores a 0");
                return;
            }

            double interesTotal = monto * (tasaAnual / 100.0) * (meses / 12.0);
            double totalAPagar = monto + interesTotal;
            double cuotaMensual = totalAPagar / meses;

            Console.WriteLine("\n---Resumen del Prestamo---");
            Console.WriteLine($"Interes total: L {interesTotal:F2}");
            Console.WriteLine($"Total a pagar: L {totalAPagar:F2}");
            Console.WriteLine($"Cuota mensual: L {cuotaMensual:F2}");

        }
    }
}