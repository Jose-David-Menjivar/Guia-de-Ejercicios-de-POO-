/*Búsqueda y ordenamiento - Llenar arreglo de 10 enteros. Implementar: búsqueda lineal,
encontrar el segundo mayor, ordenar de forma ascendente (burbuja) y mostrar elementos en
posiciones pares.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*lleno un arreglo de 10 enteros, hago la busqueda lineal revisando posicion por posicion hasta encontrar el numero, busco el mayor y luego el mayor
    de los que son menores a el para obtener el segundo mayor, ordeno con el metodo burbuja comparando cada elemento con el siguiente
    y cambiandolos con una variable temporal si estan en mal orden, y al final muestro los elementos de las posiciones pares (indices 0, 2, 4, 6 y 8)*/
    public class Ejercicio42
    {
        public void BusquedaOrdenamiento()
        {
            Console.WriteLine("=== Ejercicio 42: Busqueda y ordenamiento ===");

            int[] arreglo = new int[10];

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1} : ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine()!);
            }

            Console.Write("\nIngrese el numero que desea buscar : ");
            int buscado = Convert.ToInt32(Console.ReadLine()!);

            int posicion = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == buscado)
                {
                    posicion = i;
                    break;
                }
            }

            Console.WriteLine("\n--- Busqueda lineal ---");
            if (posicion >= 0)
            {
                Console.WriteLine($"El numero {buscado} esta en la posicion {posicion + 1}");
            }
            else
            {
                Console.WriteLine($"El numero {buscado} no esta en el arreglo");
            }

            int mayor = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
            }

            bool haySegundo = false;
            int segundoMayor = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] < mayor && (haySegundo == false || arreglo[i] > segundoMayor))
                {
                    segundoMayor = arreglo[i];
                    haySegundo = true;
                }
            }

            Console.WriteLine("\n--- Segundo mayor ---");
            if (haySegundo)
            {
                Console.WriteLine($"El mayor es {mayor} y el segundo mayor es {segundoMayor}");
            }
            else
            {
                Console.WriteLine("Todos los elementos son iguales, no hay segundo mayor");
            }

            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = 0; j < arreglo.Length - 1 - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temporal = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("\n--- Arreglo ordenado de forma ascendente ---");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine("\n\n--- Elementos en posiciones pares (indices 0, 2, 4, 6, 8) ---");
            for (int i = 0; i < arreglo.Length; i += 2)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
