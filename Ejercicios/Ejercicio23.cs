/*Tabla de multiplicar - Solicitar un número e imprimir su tabla de multiplicar
del 1 al 12 utilizando un bucle for.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    // pido un numero entero e imprimo su tabla de multiplicar del 1 al 12 utilizando un ciclo for
    public class Ejercicio23
    {
        public void MostrarTabla()
        {
            Console.WriteLine("=== Ejercicio 23: Tabla de multiplicar ===");

            Console.Write("Ingrese un número para la tabla: ");
            int numero = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"\n--- Tabla del {numero} ---");

            // Bucle for clasico de 1 a 12 sin formatos complejos
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}