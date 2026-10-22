/*Serie Fibonacci - Generar los primeros N términos de Fibonacci. Mostrar también la suma total
y el promedio.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /* pido la cantidad de terminos n valido el rango genero la serie fibonacci mediante un ciclo for y calculo la suma total y el promedio*/
    public class Ejercicio29
    {
        public void GenerarFibonacci()
        {
            Console.WriteLine("=== Ejercicio 29: Serie Fibonacci ===");

            Console.Write("¿Cuántos términos desea generar? (1-90): ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n < 1 || n > 90)
            {
                Console.WriteLine("\n[Error] La cantidad de términos debe estar en el rango de 1 a 90.");
                return;
            }

            long anterior = 0;
            long actual = 1;
            long suma = 0;

            Console.WriteLine("\n--- Serie Generada ---");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(anterior + " ");
                suma += anterior;

                long siguiente = anterior + actual;
                anterior = actual;
                actual = siguiente;
            }

            double promedio = (double)suma / n;

            Console.WriteLine("\n\n--- Resultados ---");
            Console.WriteLine($"Suma total: {suma}");
            Console.WriteLine($"Promedio:   {promedio:F2}");
        }
    }
}