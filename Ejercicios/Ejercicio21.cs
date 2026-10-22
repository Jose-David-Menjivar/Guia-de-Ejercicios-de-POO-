/*Validador de fecha - Ingresar día, mes y año por separado. Validar que sea una fecha real
considerando días por mes y años bisiestos.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /* Primero pido dia mes y anio valido que correspondan a una fecha real considerando meses de 30 o 31 dias y anios bisiestos para febrero*/
    public class Ejercicio21
    {
        public void ValidarFecha()
        {
            Console.WriteLine("=== Ejercicio 21: Validador de fecha ===");

            Console.Write("Ingrese el dia (en numeros) : ");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el mes : ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el año : ");
            int anio = Convert.ToInt32(Console.ReadLine()!);

            if (anio <= 0)
            {
                Console.WriteLine("\nERROR: El año debe ser mayor a 0");
                return;
            }

            if(mes < 1 || mes > 12)
            {
                Console.WriteLine("\nERROR: El mes debe estar entre 1 y 12");
                return;
            }

            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            int diasDelMes;
            switch (mes)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                   diasDelMes = 30;
                   break;

                case 2: 
                   diasDelMes = esBisiesto ? 29: 28;
                   break;

                default:
                   diasDelMes = 31;
                   break;
            }

            if (dia < 1 || dia > diasDelMes)
            {
                Console.WriteLine($"\nERROR: La fecha {dia}/{mes}/{anio} NO es valida: el mes {mes} solo tiene {diasDelMes} dias.");
                return;
            }

            Console.WriteLine("\n---Resultado---");
            Console.WriteLine($"La fecha {dia:D2}/{mes:D2}/{anio} es VÁLIDA");
        }
    }
}