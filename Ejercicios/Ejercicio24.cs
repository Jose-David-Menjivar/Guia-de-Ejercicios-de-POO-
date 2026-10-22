/*Suma de pares e impares - Para los números del 1 al N (N ingresado por el usuario), calcular
por separado la suma y la cantidad de números pares e impares.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido un numero n valido que sea positivo y calculo la suma y cantidad de numeros pares e impares del 1 al n usando un ciclo for*/
    public class Ejercicio24
    {
        public void SumarParesImpares()
        {
            Console.WriteLine("=== Ejercicio 24: Suma de pares e impares ===");

            Console.Write("Ingrese un número entero positivo (N): ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            // Validacion basica: que n sea mayor a cero
            if (n <= 0)
            {
                Console.WriteLine("[Error] N debe ser un número entero mayor a cero.");
                return;
            }

            int sumaPares = 0;
            int sumaImpares = 0;
            int cantidadPares = 0;
            int cantidadImpares = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumaPares += i;
                    cantidadPares++;
                }
                else
                {
                    sumaImpares += i;
                    cantidadImpares++;
                }
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Pares:   Cantidad = {cantidadPares}, Suma = {sumaPares}");
            Console.WriteLine($"Impares: Cantidad = {cantidadImpares}, Suma = {sumaImpares}");
        }
    }
}