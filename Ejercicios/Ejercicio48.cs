/*Números únicos - Leer N números enteros y agregarlos a una lista solo si no existen
previamente. Al final mostrar la lista resultante y cuántos duplicados fueron descartados.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido la cantidad N de numeros valido que sea positiva, leo los numeros con un ciclo for y uso Contains para saber si ya estan en la lista,
    si no estan los agrego con Add y si ya estan los descarto y sumo uno al contador de duplicados, al final recorro la lista con un foreach para mostrarla*/
    public class Ejercicio48
    {
        public void NumerosUnicos()
        {
            Console.WriteLine("=== Ejercicio 48: Numeros unicos ===");

            Console.Write("Cuantos numeros desea ingresar : ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n <= 0)
            {
                Console.WriteLine("ERROR: La cantidad debe ser un numero entero mayor a 0");
                return;
            }

            List<int> unicos = new List<int>();
            int duplicados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el numero {i + 1} : ");
                int numero = Convert.ToInt32(Console.ReadLine()!);

                if (unicos.Contains(numero))
                {
                    duplicados++;
                    Console.WriteLine("Numero repetido, se descarta");
                }
                else
                {
                    unicos.Add(numero);
                }
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.Write("Lista resultante : ");
            foreach (int numero in unicos)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine($"\nDuplicados descartados : {duplicados}");
        }
    }
}
