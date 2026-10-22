/*Arreglo de nombres - Almacenar 5 nombres en un arreglo de strings. Mostrar los nombres en
orden inverso, encontrar el nombre más largo y buscar un nombre ingresado por el usuario.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*guardo 5 nombres en un arreglo de strings validando que ninguno quede vacio, los muestro en orden inverso con un for que va de atras hacia adelante,
    busco el nombre mas largo comparando la cantidad de letras de cada uno y por ultimo pido un nombre y lo busco en el arreglo sin importar mayusculas o minusculas*/
    public class Ejercicio38
    {
        public void ArregloNombres()
        {
            Console.WriteLine("=== Ejercicio 38: Arreglo de nombres ===");

            string[] nombres = new string[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Ingrese el nombre {i + 1} : ");
                string nombre = Console.ReadLine()!.Trim();

                while (nombre == "")
                {
                    Console.WriteLine("ERROR: El nombre no puede estar vacio");
                    Console.Write($"Ingrese el nombre {i + 1} : ");
                    nombre = Console.ReadLine()!.Trim();
                }

                nombres[i] = nombre;
            }

            Console.WriteLine("\n--- Nombres en orden inverso ---");
            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nombres[i]);
            }

            string masLargo = nombres[0];
            foreach (string nombre in nombres)
            {
                if (nombre.Length > masLargo.Length)
                {
                    masLargo = nombre;
                }
            }

            Console.WriteLine("\n--- Nombre mas largo ---");
            Console.WriteLine($"{masLargo} ({masLargo.Length} letras)");

            Console.Write("\nIngrese el nombre que desea buscar : ");
            string buscado = Console.ReadLine()!.Trim().ToLower();

            int posicion = -1;
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower() == buscado)
                {
                    posicion = i;
                    break;
                }
            }

            Console.WriteLine("\n--- Resultado de la busqueda ---");
            if (posicion >= 0)
            {
                Console.WriteLine($"El nombre se encontro en la posicion {posicion + 1}");
            }
            else
            {
                Console.WriteLine("El nombre no esta en el arreglo");
            }
        }
    }
}
