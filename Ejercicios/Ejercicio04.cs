/*Área y perímetro - Menú para calcular área y perímetro de: círculo, triángulo, rectángulo y
trapecio. Validar que los valores ingresados sean positivos.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*Primero creo un menu para elegir entre circulo triangulo rectangulo o trapecio valido que las medidas sean 
    positivas y calculo el area y perimetro de la figura seleccionada con dos decimales con un switch para mas eficiente*/
    public class Ejercicio04
    {
        public void Calcular()
        {
            Console.WriteLine("=== Ejercicio 04: Area y perímetro ===");
            Console.WriteLine("Seleccione una figura geométrica:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.Write("Ingrese el número de la opción deseada: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                
                    Console.Write("Ingrese el radio del círculo : ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    if (radio <= 0)
                    {
                        Console.WriteLine("El valor debe ser positivo.");
                        return;
                    }
                    double areaCirculo = Math.PI * Math.Pow(radio, 2);
                    double perimetroCirculo = 2 * Math.PI * radio;
                    Console.WriteLine($"Área: {areaCirculo: F2}, Perímetro: {perimetroCirculo: F2}");
                    break;

                case 2: 
                
                    Console.Write("Ingrese la base del triángulo |: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo :");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo lado del triángulo:");
                    double lado2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el tercer lado del triángulo:");
                    double lado3 = Convert.ToDouble(Console.ReadLine());

                    if (baseTriangulo <= 0 || alturaTriangulo <= 0 || lado2 <= 0 || lado3 <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    double perimetroTriangulo = baseTriangulo + lado2 + lado3;
                    Console.WriteLine($"Área: {areaTriangulo: F2}, Perímetro: {perimetroTriangulo: F2}");
                    break;
                   
                case 3:

                    Console.Write("Ingrese el largo del rectángulo : ");
                    double largo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo : ");
                    double ancho = Convert.ToDouble(Console.ReadLine());

                    if (largo <= 0 || ancho <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    double areaRectangulo = largo * ancho;
                    double perimetroRectangulo = 2 * (largo + ancho);
                    Console.WriteLine($"Área: {areaRectangulo: F2}, Perímetro: {perimetroRectangulo: F2}");
                    break;

                case 4:

                    Console.Write("Ingrese la base mayor del trapecio : ");
                    double baseMayor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la base menor del trapecio : ");
                    double baseMenor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del trapecio : ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el lado oblicuo del trapecio : ");
                    double ladoOblicuo = Convert.ToDouble(Console.ReadLine());

                    if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || ladoOblicuo <= 0)
                    {
                        Console.WriteLine("Todos los valores deben ser positivos.");
                        return;
                    }

                    double areaTrapecio = ((baseMayor + baseMenor) * altura) / 2;
                    double perimetroTrapecio = baseMayor + baseMenor + 2 * ladoOblicuo;
                    Console.WriteLine($"Área: {areaTrapecio: F2}, Perímetro: {perimetroTrapecio: F2}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}