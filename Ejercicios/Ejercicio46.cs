/*Lista de compras - Gestionar una List<string>: agregar productos evitando duplicados
(Contains), eliminar un producto, buscar un producto específico y mostrar la lista ordenada
alfabéticamente (Sort).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*creo una List<string> para los productos y muestro un menu dentro de un ciclo while que se repite hasta elegir salir, guardo cada producto en minusculas
    para que Leche y leche cuenten como el mismo, al agregar valido que no este vacio y uso Contains para evitar duplicados, para eliminar uso Remove que me dice si lo encontro,
    para buscar uso Contains y para mostrar ordeno la lista con Sort y la recorro con un foreach*/
    public class Ejercicio46
    {
        public void ListaCompras()
        {
            Console.WriteLine("=== Ejercicio 46: Lista de compras ===");

            List<string> compras = new List<string>();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar lista ordenada");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese la opcion deseada : ");
                opcion = Convert.ToInt32(Console.ReadLine()!);

                if (opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("ERROR: Opcion no valida, elija una opcion del 0 al 4");
                }
                else if (opcion == 1)
                {
                    Console.Write("Ingrese el producto : ");
                    string producto = Console.ReadLine()!.Trim().ToLower();

                    if (producto == "")
                    {
                        Console.WriteLine("ERROR: El producto no puede estar vacio");
                    }
                    else if (compras.Contains(producto))
                    {
                        Console.WriteLine("ERROR: Ese producto ya esta en la lista");
                    }
                    else
                    {
                        compras.Add(producto);
                        Console.WriteLine("Producto agregado");
                    }
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el producto a eliminar : ");
                    string producto = Console.ReadLine()!.Trim().ToLower();

                    if (compras.Remove(producto))
                    {
                        Console.WriteLine("Producto eliminado");
                    }
                    else
                    {
                        Console.WriteLine("Ese producto no esta en la lista");
                    }
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el producto a buscar : ");
                    string producto = Console.ReadLine()!.Trim().ToLower();

                    if (compras.Contains(producto))
                    {
                        Console.WriteLine("El producto SI esta en la lista");
                    }
                    else
                    {
                        Console.WriteLine("El producto NO esta en la lista");
                    }
                }
                else if (opcion == 4)
                {
                    if (compras.Count == 0)
                    {
                        Console.WriteLine("La lista esta vacia");
                    }
                    else
                    {
                        compras.Sort();

                        Console.WriteLine("\n--- Lista de compras ordenada ---");
                        foreach (string producto in compras)
                        {
                            Console.WriteLine(producto);
                        }
                    }
                }
            }
        }
    }
}
