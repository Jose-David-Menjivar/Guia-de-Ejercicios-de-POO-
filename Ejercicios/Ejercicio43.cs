/*Rotación de arreglo - Crear arreglo de N elementos. Implementar menú para: rotar K
posiciones a la izquierda, rotar K posiciones a la derecha, invertir el arreglo.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido el tamaño N y los elementos del arreglo y muestro un menu dentro de un ciclo while que se repite hasta elegir salir, para rotar a la izquierda
    guardo el primer elemento, corro todos una posicion y lo pongo al final, para rotar a la derecha guardo el ultimo, corro todos
    y lo pongo al inicio, esto se repite K veces (K entre N para no dar vueltas de mas) y para invertir intercambio el primero con el ultimo y asi hasta la mitad*/
    public class Ejercicio43
    {
        public void RotacionArreglo()
        {
            Console.WriteLine("=== Ejercicio 43: Rotacion de arreglo ===");

            Console.Write("Ingrese el tamaño del arreglo : ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n <= 0)
            {
                Console.WriteLine("ERROR: El tamaño debe ser un numero entero mayor a 0");
                return;
            }

            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el elemento {i + 1} : ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine()!);
            }

            int opcion = -1;

            while (opcion != 0)
            {
                Console.Write("\nArreglo actual : ");
                foreach (int elemento in arreglo)
                {
                    Console.Write(elemento + " ");
                }

                Console.WriteLine("\n\n1. Rotar K posiciones a la izquierda");
                Console.WriteLine("2. Rotar K posiciones a la derecha");
                Console.WriteLine("3. Invertir el arreglo");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese la opcion deseada : ");
                opcion = Convert.ToInt32(Console.ReadLine()!);

                if (opcion < 0 || opcion > 3)
                {
                    Console.WriteLine("ERROR: Opcion no valida, elija una opcion del 0 al 3");
                }
                else if (opcion == 1 || opcion == 2)
                {
                    Console.Write("Ingrese el valor de K : ");
                    int k = Convert.ToInt32(Console.ReadLine()!);

                    if (k <= 0)
                    {
                        Console.WriteLine("ERROR: K debe ser un numero entero mayor a 0");
                    }
                    else if (opcion == 1)
                    {
                        RotarIzquierda(arreglo, k);
                    }
                    else
                    {
                        RotarDerecha(arreglo, k);
                    }
                }
                else if (opcion == 3)
                {
                    InvertirArreglo(arreglo);
                }
            }
        }

        private void RotarIzquierda(int[] arreglo, int k)
        {
            k = k % arreglo.Length;

            for (int vez = 0; vez < k; vez++)
            {
                int primero = arreglo[0];

                for (int i = 0; i < arreglo.Length - 1; i++)
                {
                    arreglo[i] = arreglo[i + 1];
                }

                arreglo[arreglo.Length - 1] = primero;
            }
        }

        private void RotarDerecha(int[] arreglo, int k)
        {
            k = k % arreglo.Length;

            for (int vez = 0; vez < k; vez++)
            {
                int ultimo = arreglo[arreglo.Length - 1];

                for (int i = arreglo.Length - 1; i > 0; i--)
                {
                    arreglo[i] = arreglo[i - 1];
                }

                arreglo[0] = ultimo;
            }
        }

        private void InvertirArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length / 2; i++)
            {
                int temporal = arreglo[i];
                arreglo[i] = arreglo[arreglo.Length - 1 - i];
                arreglo[arreglo.Length - 1 - i] = temporal;
            }
        }
    }
}
