/*Tarifa de estacionamiento - Calcular el pago según las horas estacionado: la primera hora
cuesta L20, cada hora adicional L10, con un tope máximo de L100 por día. Validar que las horas
sean positivas.*/
namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido las horas de estacionamiento valido que sean positivas calculo la tarifa con la primera hora a 20 y adicionales a 10 y aplico el tope maximo de 100*/
    public class Ejercicio18
    {
        public void CalcularEstacionamiento()
        {
            Console.WriteLine("=== Ejercicio 18: Tarifa de estacionamiento ===");
            
            Console.Write("Ingrese las horas estacionado : ");
            int horas = Convert.ToInt32(Console.ReadLine()!);

            if(horas <= 0)
            {
                Console.WriteLine("ERROR: Las horas deben ser un número entero mayor a 0");
                return;
            }

            int total;

            if(horas == 1)
            {
                total = 20;
            }
            else
            {
                int horasAdicionales = horas - 1;
                total = 20 + (horasAdicionales * 10);
            }

            if(total > 100)
            {
                total = 100;
            }

            Console.WriteLine("\n--- Resumen de Cobro ---");
            Console.WriteLine($"Horas estacionado : {horas}");
            Console.WriteLine($"Total a pagar : {total}.00");
        }
    }
}