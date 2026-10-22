/*Decimal a binario - Convertir un número entero positivo a binario usando divisiones sucesivas
entre 2 dentro de un ciclo.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*Primero pido un numero entero positivo y lo convierto a binario mediante divisiones
     sucesivas entre dos y concatenacion de residuos usando un ciclo while*/
    public class Ejercicio28
    {
        public void ConvertirDecimalABinario()
        {
            Console.WriteLine("=== Ejercicio 28: Decimal a binario ===");

            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine()!);

            if (numero < 0)
            {
                Console.WriteLine("\n[Error] El número no puede ser negativo.");
                return;
            }

            int copia = numero;
            string binario = "";

            if (copia == 0)
            {
                binario = "0";
            }

            while (copia > 0)
            {
                int residuo = copia % 2;
                binario = residuo + binario; 
                copia = copia / 2;
            }

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"El número {numero} en binario es: {binario}");
        }
    }
}
