/*Vocal o consonante - Solicitar una letra e indicar si es vocal o consonante usando switch.
Validar que realmente sea una letra.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /* Lee una entrada, valida que sea un solo caracter y una letra (A-Z o a-z), y con un switch indica si es vocal o consonante*/
    public class Ejercicio15
    {
        public void EvaluarLetra()
        {
            Console.WriteLine("=== Ejercicio 15: Vocal o consonante ===");

            Console.Write("Ingrese una sola letra: ");
            string entrada = Console.ReadLine()!;

            if (entrada.Length != 1)
            {
                Console.WriteLine("[Error] Debe ingresar un solo caracter.");
                return;
            }

            char letra = entrada[0];

            if (!((letra >= 'a' && letra <= 'z') || (letra >= 'A' && letra <= 'Z')))
            {
                Console.WriteLine("[Error] Lo que ingreso no es una letra del abecedario.");
                return;
            }

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"\nLa letra '{letra}' es una vocal.");
                    break;

                default:
                    Console.WriteLine($"\nLa letra '{letra}' es una consonante.");
                    break;
            }
        }
    }
}