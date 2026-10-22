/*Arreglo de temperaturas - Registrar temperaturas de 7 días. Mostrar: promedio semanal, días
sobre el promedio, día más caluroso, día más frío y variación entre días consecutivos.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*guardo las temperaturas de 7 dias en un arreglo validando que esten entre -50 y 60 grados y uso otro arreglo con los nombres de los dias,
    calculo el promedio y guardo la posicion del dia mas caluroso y del mas frio, muestro los dias que estan sobre el promedio
    y la variacion entre dias consecutivos restando la temperatura de un dia menos la del dia anterior*/
    public class Ejercicio41
    {
        public void ArregloTemperaturas()
        {
            Console.WriteLine("=== Ejercicio 41: Arreglo de temperaturas ===");

            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            double[] temperaturas = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese la temperatura del {dias[i]} (°C) : ");
                double temperatura = Convert.ToDouble(Console.ReadLine()!);

                while (temperatura < -50 || temperatura > 60)
                {
                    Console.WriteLine("ERROR: La temperatura debe estar entre -50 y 60 grados");
                    Console.Write($"Ingrese la temperatura del {dias[i]} (°C) : ");
                    temperatura = Convert.ToDouble(Console.ReadLine()!);
                }

                temperaturas[i] = temperatura;
            }

            double suma = 0;
            int posicionCalido = 0;
            int posicionFrio = 0;

            for (int i = 0; i < 7; i++)
            {
                suma += temperaturas[i];

                if (temperaturas[i] > temperaturas[posicionCalido])
                {
                    posicionCalido = i;
                }
                if (temperaturas[i] < temperaturas[posicionFrio])
                {
                    posicionFrio = i;
                }
            }

            double promedio = suma / 7;

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio semanal : {promedio:F2} °C");

            Console.WriteLine("\nDias sobre el promedio :");
            bool hayDiasSobrePromedio = false;
            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine($"{dias[i]} : {temperaturas[i]:F1} °C");
                    hayDiasSobrePromedio = true;
                }
            }
            if (hayDiasSobrePromedio == false)
            {
                Console.WriteLine("Ningun dia supero el promedio");
            }

            Console.WriteLine($"\nDia mas caluroso : {dias[posicionCalido]} ({temperaturas[posicionCalido]:F1} °C)");
            Console.WriteLine($"Dia mas frio : {dias[posicionFrio]} ({temperaturas[posicionFrio]:F1} °C)");

            Console.WriteLine("\nVariacion entre dias consecutivos :");
            for (int i = 1; i < 7; i++)
            {
                double variacion = temperaturas[i] - temperaturas[i - 1];
                Console.WriteLine($"{dias[i - 1]} a {dias[i]} : {variacion:F1} °C");
            }
        }
    }
}
