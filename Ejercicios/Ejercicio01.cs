/*Conversor de moneda - Solicitar un monto en lempiras y la tasa de cambio del día. Convertir el
monto a dólares y a euros, mostrando los resultados con dos decimales.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    public class Ejercicio01
    {
        public void Ejecutar()
        {
        /*primero creo el metodo le pregunto el monto que desea convertir en lempiras y luego le pregunto
        la tasa en dolares y euros y luego en resultados imprime la conversion de los dos.*/
            Console.WriteLine("=== Ejercicio 01: Conversor de moneda ===");
            Console.Write("Cual monto desea convertir en lempiras : ");
            double lempiras = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cual es la tasa del día (lempiras por 1 dólar) : ");
            double tasaDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cual es la tasa del día (lempiras por 1 euro) : ");
            double tasaEuro = Convert.ToDouble(Console.ReadLine());

            if(lempiras <= 0 || tasaDolar <= 0 || tasaEuro <= 0)
            {
                Console.WriteLine("ERROR: Los valores ingresados deben ser mayores a cero.");
                return;
            }

            double dolares = lempiras / tasaDolar;
            double euros = lempiras / tasaEuro;

            Console.WriteLine("-----RESULTADOS-----");
            Console.WriteLine($"L {lempiras:F2} = $ {dolares:F2} dólares");
            Console.WriteLine($"L {lempiras:F2} = € {euros:F2} euros");
            Console.WriteLine("--------------------");

        }
    }
}