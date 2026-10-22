/*Inversión de número - Invertir los dígitos de un número entero usando while, división entera y
módulo. Indicar además si el número es palíndromo (capicúa).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido un numero entero positivo invierto sus digitos usando un ciclo while con division y residuo y determino si es palindromo*/
    public class Ejercicio27
    {
public void InvertirNumero()
        {
            Console.WriteLine("=== Ejercicio 27: Inversión de número ===");

            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine()!);

            if (numero <= 0)
            {
                Console.WriteLine("\n[Error] El número debe ser un entero mayor a cero.");
                return;
            }

            int copia = numero;
            long invertido = 0;

            while (copia > 0)
            {
                int ultimoDigito = copia % 10;
                invertido = (invertido * 10) + ultimoDigito;
                copia = copia / 10;
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Número original:  {numero}");
            Console.WriteLine($"Número invertido: {invertido}");

            if (numero == invertido)
            {
                Console.WriteLine("Resultado: Es un número palíndromo (capicúa).");
            }
            else
            {
                Console.WriteLine("Resultado: No es un número palíndromo.");
            }
        }
    }
}