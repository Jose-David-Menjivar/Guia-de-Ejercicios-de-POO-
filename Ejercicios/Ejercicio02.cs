/*Calculadora de IMC - Solicitar peso (kg) y altura (m), calcular el índice de masa corporal y
mostrar en qué categoría se encuentra (bajo peso, normal, sobrepeso, obesidad).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    public class Ejercicio02
    {
        /*Primero se solicita el peso en kg y la altura como lo pide, y luego se calcula la masa corporal, se hace un if por si el usuario 
        ingresa un valor menor a 0 y luego se hace una evaluacion por rangos con if y else para determinar en que categoria se encuentra*/
        public void Calculadora()
        {
            Console.WriteLine("=== Ejercicio 02 Calculadora de IMC ===");
            Console.Write("Ingrese su peso en kilogramos (kg) : ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros (m) : ");
            double altura = Convert.ToDouble(Console.ReadLine());

            if(peso <= 0 || altura <= 0)
            {
                Console.WriteLine("ERROR: los valores ingresados deben ser mayores a cero.");
                return;
            }

            double imc = peso / (altura * altura);

            Console.WriteLine("-----RESULTADOS-----");
            Console.WriteLine($"Su IMC es: {imc:F2}");

            if(imc < 18.5)
            {
                Console.WriteLine("Categoria: Bajo peso");
            }
            else if(imc < 25)
            {
                Console.WriteLine("Categoria: Normal");
            }
            else if(imc < 30)
            {
                Console.WriteLine("Categoria: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Categoria: Obesidad");
            }
        }
    }
}