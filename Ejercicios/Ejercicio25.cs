/*Promedio con centinela - Leer números hasta que el usuario ingrese -1. Calcular y mostrar el
promedio, el valor máximo y el mínimo de los valores ingresados (sin contar el -1).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// leo numeros hasta que se ingrese el centinela menos uno y calculo el promedio 
    el valor maximo y el minimo sin incluirlo usando un ciclo while*/
    public class Ejercicio25
    {
        public void CalcularPromedioCentinela()
        {
            Console.WriteLine("=== Ejercicio 25: Promedio con centinela ===");
            Console.WriteLine("Ingrese números uno por uno. Escriba -1 para finalizar");

            double suma = 0;
            double mayor = 0;
            double menor = 0;
            int cantidad = 0;

                while (true)
                {
                    Console.Write("Ingrese un número : ");
                    double numero = Convert.ToDouble(Console.ReadLine()!);

                    if(numero == -1)
                    {
                        break;
                    }
                    
                    if(cantidad == 0)
                    {
                        mayor = numero;
                        menor = numero;
                    }
                    else
                    {
                        if(numero > mayor)
                        {
                            mayor = numero;
                        }
                        if(numero < menor)
                        {
                            menor = numero;
                        }
                    }

                    suma += numero;
                    cantidad++;
                }

                Console.WriteLine("\n---Resultados---");
                if(cantidad == 0)
                {
                    Console.WriteLine("No se ingresaron números válidos antes del centinela.");
                }
                else
                {
                    double promedio = suma / cantidad;
                    Console.WriteLine($"Cantidad de números : {cantidad}");
                    Console.WriteLine($"Promedio :            {promedio:F2}");
                    Console.WriteLine($"Maximo :              {mayor}");
                    Console.WriteLine($"Minimo :              {menor}");
                }
            }
        }
    }
