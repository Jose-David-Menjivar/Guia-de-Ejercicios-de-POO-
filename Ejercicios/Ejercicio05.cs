/*Conversión de temperatura - Crear un menú que permita convertir entre Celsius, Fahrenheit y
Kelvin. El usuario elige la conversión deseada.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*Primero muestro un menu para convertir temperaturas entre celsius, fahrenheit 
    y kelvin validando las opciones y mostrando el resultado con un switch con sus respetivas calculos y con dos decimales*/
    public class Ejercicio05
    {
        public void ConvertirTemperatura()
        {
            Console.WriteLine("=== Ejercicio 05: Conversión de temperatura ===");
            Console.WriteLine("Seleccione la conversión deseada:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Celsius a Kelvin");
            Console.WriteLine("3. Fahrenheit a Celsius");
            Console.WriteLine("4. Fahrenheit a Kelvin");
            Console.WriteLine("5. Kelvin a Celsius");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.Write("Ingrese el número de la opción deseada: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            double temperatura;
            double resultado;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la temperatura en Celsius : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"{temperatura:F2} °C = {resultado:F2} °F");
                    break;
                
                case 2:
                    Console.Write("Ingrese la temperatura en Celsius : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = temperatura + 273.15;
                    Console.WriteLine($"{temperatura:F2} °C = {resultado:F2} K");
                    break;
                
                case 3:
                    Console.Write("Ingrese la temperatura en Fahrenheit : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura:F2} °F = {resultado:F2} °C");
                    break;

                case 4:
                    Console.Write("Ingrese la temperatura en Fahrenheit : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{temperatura:F2} °F = {resultado:F2} K");
                    break;

                case 5:
                    Console.Write("Ingrese la temperatura en Kelvin : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = temperatura - 273.15;
                    Console.WriteLine($"{temperatura:F2} K = {resultado:F2} °C");
                    break;

                case 6:
                    Console.Write("Ingrese la temperatura en Kelvin : ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"{temperatura:F2} K = {resultado:F2} °F");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 6.");
                    break;
            }
        }
    }
}