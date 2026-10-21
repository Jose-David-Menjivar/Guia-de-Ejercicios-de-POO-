/*Calculadora con switch - Mostrar un menú con las operaciones +, -, *, / y %. Validar la división y
el módulo entre cero mostrando un mensaje de error.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido dos numeros y un operador aritmetico ejecuto la operacion mediante un switch y valido que el divisor no sea cero en division y modulo*/
    
    public class Ejercicio14
    {
        public void CalculadoraSwitch()
        {
            Console.WriteLine("=== Ejercicio 14: Calculadora con switch");
            Console.WriteLine("Operaciones disponibles: + - * / % ");

            Console.Write("ELija la operacion : ");
            string operacion = Console.ReadLine()!;

            Console.Write("Ingrese el primer número : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número : ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n--- RESULTADO ---");

            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b} ");
                    break;

                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b} ");
                    break;

                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b} ");
                    break;

                case "/":
                    if(b == 0)
                    {
                        Console.WriteLine("ERROR: no se puede dividir entre 0");
                    }

                    else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b} ");
                    }
                    break;

                case "%":
                    if(b == 0)
                    {
                        Console.WriteLine("ERROR: No se puede calcular el modulo entre cero");
                    }

                    else
                    {
                        Console.WriteLine($"{a} % {b} = {a % b} ");
                    }
                    break;

                default:
                    Console.WriteLine("Error operacion No valida.");
                    break;
            }

        }
    }
}