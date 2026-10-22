/*Histograma de calificaciones - Registrar N calificaciones (0-100) en un arreglo, contar cuántas
caen en cada rango (0-59, 60-69, 70-79, 80-89, 90-100) y dibujar el histograma con barras de
asteriscos.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido la cantidad N de calificaciones valido que sea positiva y las guardo en un arreglo validando que cada una este entre 0 y 100,
    uso otro arreglo de 5 posiciones como contador donde cada posicion es un rango, clasifico cada nota con if y else if,
    y dibujo el histograma con un ciclo for que escribe un asterisco por cada nota que cayo en ese rango*/
    public class Ejercicio44
    {
        public void HistogramaCalificaciones()
        {
            Console.WriteLine("=== Ejercicio 44: Histograma de calificaciones ===");

            Console.Write("Cuantas calificaciones desea ingresar : ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n <= 0)
            {
                Console.WriteLine("ERROR: La cantidad debe ser un numero entero mayor a 0");
                return;
            }

            int[] notas = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese la calificacion {i + 1} (0-100) : ");
                int nota = Convert.ToInt32(Console.ReadLine()!);

                while (nota < 0 || nota > 100)
                {
                    Console.WriteLine("ERROR: La calificacion debe ser un numero entero entre 0 y 100");
                    Console.Write($"Ingrese la calificacion {i + 1} (0-100) : ");
                    nota = Convert.ToInt32(Console.ReadLine()!);
                }

                notas[i] = nota;
            }

            int[] conteo = new int[5];

            for (int i = 0; i < n; i++)
            {
                if (notas[i] <= 59)
                {
                    conteo[0]++;
                }
                else if (notas[i] <= 69)
                {
                    conteo[1]++;
                }
                else if (notas[i] <= 79)
                {
                    conteo[2]++;
                }
                else if (notas[i] <= 89)
                {
                    conteo[3]++;
                }
                else
                {
                    conteo[4]++;
                }
            }

            string[] rangos = { "0-59  ", "60-69 ", "70-79 ", "80-89 ", "90-100" };

            Console.WriteLine("\n--- Histograma ---");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(rangos[i] + " | ");

                for (int j = 0; j < conteo[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine($" ({conteo[i]})");
            }
        }
    }
}
