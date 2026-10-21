/*Año bisiesto y días del mes - Solicitar año y mes, determinar si es bisiesto y mostrar cuántos
días tiene ese mes.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido el anio y mes valido los rangos determino si el anio es bisiesto con operadores logicos y calculo los dias del mes mediante un switch*/
    public class Ejercicio20
    {
        public void CalcularDiasDelMes()
        {
            Console.WriteLine("=== Ejercicio 20: Año bisiesto y dias del mes ===");

            Console.Write("Ingrese el año : ");
            int anio = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Ingrese el mes (1-12) : ");
            int mes = Convert.ToInt32(Console.ReadLine()!);

            if(anio <= 0)
            {
                Console.WriteLine("ERROR: El año debe ser un numero entero mayor a 0");
                return;
            }

            if(mes < 1 || mes > 12)
            {
                Console.WriteLine("ERROR: El mes debe estar entre 1 y 12.");
                return;
            }

            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            int dias;
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                     dias = 31;
                     break;

                case 4:
                case 6:
                case 9:
                case 11:
                     dias = 30;
                     break;

                case 2:

                     dias = esBisiesto ? 29 : 28;
                     break;

                default:
                     dias = 0;
                     break;
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine(esBisiesto ? $"{anio} es un año bisiesto" : $"{anio} No es un año bisiesto");
            Console.WriteLine($"El mes {mes} del año {anio} tiene {dias} dias");
        }
    }
}