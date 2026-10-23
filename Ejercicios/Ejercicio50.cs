/*Registro de estudiantes - Usar una List<string> de nombres y una List<double> de
promedios (listas paralelas). Menú: agregar estudiante, buscar por nombre, mostrar el
estudiante con mejor promedio y listado general.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*uso dos listas paralelas, una de nombres y otra de promedios, donde la misma posicion en las dos listas es el mismo estudiante, muestro un menu dentro
    de un ciclo while que se repite hasta elegir salir, al agregar valido que el nombre no este vacio y que el promedio este entre 0 y 100 y agrego a las dos listas,
    para buscar comparo el nombre sin importar mayusculas y uso la posicion encontrada para sacar tambien el promedio, para el mejor promedio busco la posicion del promedio mas alto
    y para el listado recorro las dos listas con un for*/
    public class Ejercicio50
    {
        public void RegistroEstudiantes()
        {
            Console.WriteLine("=== Ejercicio 50: Registro de estudiantes ===");

            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n1. Agregar estudiante");
                Console.WriteLine("2. Buscar por nombre");
                Console.WriteLine("3. Mostrar el estudiante con mejor promedio");
                Console.WriteLine("4. Listado general");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese la opcion deseada : ");
                opcion = Convert.ToInt32(Console.ReadLine()!);

                if (opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("ERROR: Opcion no valida, elija una opcion del 0 al 4");
                }
                else if (opcion == 1)
                {
                    Console.Write("Ingrese el nombre del estudiante : ");
                    string nombre = Console.ReadLine()!.Trim();

                    if (nombre == "")
                    {
                        Console.WriteLine("ERROR: El nombre no puede estar vacio");
                    }
                    else
                    {
                        Console.Write("Ingrese el promedio (0-100) : ");
                        double promedio = Convert.ToDouble(Console.ReadLine()!);

                        if (promedio < 0 || promedio > 100)
                        {
                            Console.WriteLine("ERROR: El promedio debe estar en el rango de 0 a 100");
                        }
                        else
                        {
                            nombres.Add(nombre);
                            promedios.Add(promedio);
                            Console.WriteLine("Estudiante agregado");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el nombre a buscar : ");
                    string buscado = Console.ReadLine()!.Trim().ToLower();

                    int posicion = -1;
                    for (int i = 0; i < nombres.Count; i++)
                    {
                        if (nombres[i].ToLower() == buscado)
                        {
                            posicion = i;
                            break;
                        }
                    }

                    if (posicion >= 0)
                    {
                        Console.WriteLine($"{nombres[posicion]} - Promedio : {promedios[posicion]:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Estudiante no encontrado");
                    }
                }
                else if (opcion == 3)
                {
                    if (nombres.Count == 0)
                    {
                        Console.WriteLine("No hay estudiantes registrados");
                    }
                    else
                    {
                        int posicionMejor = 0;
                        for (int i = 1; i < promedios.Count; i++)
                        {
                            if (promedios[i] > promedios[posicionMejor])
                            {
                                posicionMejor = i;
                            }
                        }

                        Console.WriteLine($"Mejor promedio : {nombres[posicionMejor]} con {promedios[posicionMejor]:F2}");
                    }
                }
                else if (opcion == 4)
                {
                    if (nombres.Count == 0)
                    {
                        Console.WriteLine("No hay estudiantes registrados");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Listado general ---");
                        for (int i = 0; i < nombres.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {nombres[i]} - {promedios[i]:F2}");
                        }
                    }
                }
            }
        }
    }
}
