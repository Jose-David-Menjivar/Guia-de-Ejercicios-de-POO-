/*Positivo, negativo o cero - Solicitar un número entero e indicar si es positivo, negativo o cero.
Además, usando el operador ternario, mostrar si el número es par o impar.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido un numero entero determino si es positivo negativo o cero usando 
    condicionales y muestro si es par o impar con un operador ternario*/
    public class Ejercicio11
    {
        public void NumeroEntero()
        {
            Console.WriteLine("===Ejercicio 11: Positivo, negativo o cero");

            Console.Write("Ingrese un numero entero : ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }

            else if(numero < 0)
            {
                Console.WriteLine("El numero es Negativo");
            }

            else
            {
               Console.WriteLine("El numero es Cero."); 
            }

            string parOimpar = (numero % 2 == 0) ? "par" : "impar";
            Console.WriteLine($"Ademas, es {parOimpar}");

        }
    }
}