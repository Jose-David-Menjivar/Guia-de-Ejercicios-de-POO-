/*Lista de tareas pendientes - Usar una List<string> con menú: agregar tarea, mostrar todas las
tareas numeradas, eliminar una tarea por su número y mostrar el total de tareas pendientes.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*creo una List<string> para guardar las tareas y muestro un menu dentro de un ciclo while que se repite hasta elegir salir, para agregar valido que la tarea no este vacia
    y uso Add, para mostrar recorro la lista con un for numerando desde 1, para eliminar valido que el numero exista y uso RemoveAt con el numero menos 1
    porque la lista empieza en 0, y para el total uso Count*/
    public class Ejercicio45
    {
        public void ListaTareas()
        {
            Console.WriteLine("=== Ejercicio 45: Lista de tareas pendientes ===");

            List<string> tareas = new List<string>();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n1. Agregar tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Total de tareas pendientes");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese la opcion deseada : ");
                opcion = Convert.ToInt32(Console.ReadLine()!);

                if (opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("ERROR: Opcion no valida, elija una opcion del 0 al 4");
                }
                else if (opcion == 1)
                {
                    Console.Write("Ingrese la nueva tarea : ");
                    string tarea = Console.ReadLine()!.Trim();

                    if (tarea == "")
                    {
                        Console.WriteLine("ERROR: La tarea no puede estar vacia");
                    }
                    else
                    {
                        tareas.Add(tarea);
                        Console.WriteLine("Tarea agregada");
                    }
                }
                else if (opcion == 2)
                {
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas pendientes");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Tareas pendientes ---");
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                    }
                }
                else if (opcion == 3)
                {
                    if (tareas.Count == 0)
                    {
                        Console.WriteLine("No hay tareas para eliminar");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Tareas pendientes ---");
                        for (int i = 0; i < tareas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }

                        Console.Write("Ingrese el numero de la tarea a eliminar : ");
                        int numero = Convert.ToInt32(Console.ReadLine()!);

                        if (numero < 1 || numero > tareas.Count)
                        {
                            Console.WriteLine($"ERROR: El numero debe estar entre 1 y {tareas.Count}");
                        }
                        else
                        {
                            tareas.RemoveAt(numero - 1);
                            Console.WriteLine("Tarea eliminada");
                        }
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine($"Total de tareas pendientes : {tareas.Count}");
                }
            }
        }
    }
}
