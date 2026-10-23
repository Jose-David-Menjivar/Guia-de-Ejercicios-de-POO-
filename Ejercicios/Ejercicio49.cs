/*Separar pares e impares - Llenar una lista con 15 números enteros, recorrerla y separar sus
valores en una lista de pares y otra de impares. Mostrar ambas listas ordenadas.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*lleno una lista con 15 numeros enteros, la recorro con un foreach y segun el residuo entre 2 agrego cada numero a la lista de pares o a la de impares,
    ordeno las dos listas con Sort y las muestro, si alguna queda vacia muestro un mensaje*/
    public class Ejercicio49
    {
        public void SepararParesImpares()
        {
            Console.WriteLine("=== Ejercicio 49: Separar pares e impares ===");

            List<int> numeros = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Ingrese el numero {i + 1} de 15 : ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()!));
            }

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }

            pares.Sort();
            impares.Sort();

            Console.WriteLine("\n--- Resultados ---");

            Console.Write("Pares ordenados : ");
            if (pares.Count == 0)
            {
                Console.Write("ninguno");
            }
            foreach (int par in pares)
            {
                Console.Write(par + " ");
            }

            Console.Write("\nImpares ordenados : ");
            if (impares.Count == 0)
            {
                Console.Write("ninguno");
            }
            foreach (int impar in impares)
            {
                Console.Write(impar + " ");
            }
            Console.WriteLine();
        }
    }
}
