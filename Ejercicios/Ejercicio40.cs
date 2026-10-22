/*Frecuencia de elementos - Generar 20 números aleatorios (1-10). Mostrar la frecuencia de
cada número y cuál es el más y menos frecuente.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*genero 20 numeros aleatorios del 1 al 10 y los guardo en un arreglo, uso otro arreglo de 11 posiciones como contador donde la posicion
    es el numero y el valor es cuantas veces salio, luego recorro los contadores del 1 al 10 para mostrar la frecuencia de cada uno y
    encontrar el mas frecuente y el menos frecuente (si hay empate se muestra el primero que se encuentra)*/
    public class Ejercicio40
    {
        public void FrecuenciaElementos()
        {
            Console.WriteLine("=== Ejercicio 40: Frecuencia de elementos ===");

            Random aleatorio = new Random();
            int[] numeros = new int[20];
            int[] frecuencia = new int[11];

            Console.WriteLine("Numeros generados :");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 11);
                frecuencia[numeros[i]]++;
                Console.Write(numeros[i] + " ");
            }

            int masFrecuente = 1;
            int menosFrecuente = 1;

            Console.WriteLine("\n\n--- Frecuencia de cada numero ---");
            for (int numero = 1; numero <= 10; numero++)
            {
                Console.WriteLine($"El numero {numero} salio {frecuencia[numero]} vez/veces");

                if (frecuencia[numero] > frecuencia[masFrecuente])
                {
                    masFrecuente = numero;
                }
                if (frecuencia[numero] < frecuencia[menosFrecuente])
                {
                    menosFrecuente = numero;
                }
            }
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Mas frecuente : {masFrecuente} ({frecuencia[masFrecuente]} veces)");
            Console.WriteLine($"Menos frecuente : {menosFrecuente} ({frecuencia[menosFrecuente]} veces)");
        }
    }
}
