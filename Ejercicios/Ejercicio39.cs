/*Estadísticas de calificaciones - Ingresar N calificaciones en un arreglo. Calcular: promedio,
máxima, mínima, cantidad de aprobados/reprobados y desviación estándar.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido la cantidad N de calificaciones valido que sea positiva y las guardo en un arreglo validando que cada una este entre 0 y 100,
    con un ciclo for calculo la suma, la maxima, la minima y cuantas son aprobadas (65 o mas) y reprobadas, el promedio es la suma entre N
    y la desviacion estandar la saco sumando el cuadrado de la diferencia de cada nota con el promedio, dividiendo entre N y sacando la raiz cuadrada*/
    public class Ejercicio39
    {
        public void EstadisticasCalificaciones()
        {
            Console.WriteLine("=== Ejercicio 39: Estadisticas de calificaciones ===");

            Console.Write("Cuantas calificaciones desea ingresar : ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n <= 0)
            {
                Console.WriteLine("ERROR: La cantidad debe ser un numero entero mayor a 0");
                return;
            }

            double[] notas = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese la calificacion {i + 1} (0-100) : ");
                double nota = Convert.ToDouble(Console.ReadLine()!);

                while (nota < 0 || nota > 100)
                {
                    Console.WriteLine("ERROR: La calificacion debe estar en el rango de 0 a 100");
                    Console.Write($"Ingrese la calificacion {i + 1} (0-100) : ");
                    nota = Convert.ToDouble(Console.ReadLine()!);
                }

                notas[i] = nota;
            }

            double suma = 0;
            double maxima = notas[0];
            double minima = notas[0];
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < n; i++)
            {
                suma += notas[i];

                if (notas[i] > maxima)
                {
                    maxima = notas[i];
                }
                if (notas[i] < minima)
                {
                    minima = notas[i];
                }

                if (notas[i] >= 65)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double promedio = suma / n;

            double sumaCuadrados = 0;
            for (int i = 0; i < n; i++)
            {
                double diferencia = notas[i] - promedio;
                sumaCuadrados += diferencia * diferencia;
            }
            double desviacion = Math.Sqrt(sumaCuadrados / n);

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Promedio : {promedio:F2}");
            Console.WriteLine($"Maxima : {maxima:F2}");
            Console.WriteLine($"Minima : {minima:F2}");
            Console.WriteLine($"Aprobados : {aprobados}");
            Console.WriteLine($"Reprobados : {reprobados}");
            Console.WriteLine($"Desviacion estandar : {desviacion:F2}");
        }
    }
}
