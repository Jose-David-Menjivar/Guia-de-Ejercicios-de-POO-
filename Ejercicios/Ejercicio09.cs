/*Cálculo de salario semanal - Ingresar horas trabajadas y tarifa por hora. Las horas extras (más
de 44) se pagan al 150%. Mostrar desglose y total.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*Primero pido las horas trabajadas y el pago por hora valido que sean positivos y 
    calculo el salario con desglose de horas normales y horas extras pagadas al 150%*/
    public class Ejercicio09
    {
        public void CalcularSalario()
        {
            Console.WriteLine("=== Ejercicio 09: Salario semanal ===");

            Console.Write("Ingrese las horas trabajadas en la semana : ");
            double horas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tarifa por hora (L) : ");
            double tarifa = Convert.ToDouble(Console.ReadLine());

            if(horas <= 0 || tarifa <= 0)
            {
                Console.WriteLine("ERROR: Las horas trabajadas y la tarifa deben ser mayores a 0");
                return;
            }

            double horasNormales;
            double horasExtra;

            if(horas > 44)
            {
                horasNormales = 44;
                horasExtra = horas - 44;
            }

            else
            {
                horasNormales = horas;
                horasExtra = 0;
            }

            double pagoNormal = horasNormales * tarifa;
            double pagoExtra = horasExtra * (tarifa *1.5);
            double total = pagoNormal + pagoExtra;

            Console.WriteLine("\n---Desglose de Salario---");
            Console.WriteLine($"Horas Normales ({horasNormales:F2} h): L {pagoNormal:F2}");
            Console.WriteLine($"Horas extras ({horasExtra:F2} h): L {pagoExtra:F2}");
            Console.WriteLine($"Total a pagar: L {total:F2}");
        }
    }
}