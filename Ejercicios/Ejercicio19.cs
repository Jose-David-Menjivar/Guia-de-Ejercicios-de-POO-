/*Clasificación de triángulos - Dados tres lados, determinar si forman un triángulo válido y
clasificarlo (equilátero, isósceles, escaleno) y por sus ángulos (rectángulo, acutángulo,
obtusángulo).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido tres lados valido que formen un triangulo y lo clasifico segun sus lados y segun sus angulos aplicando el teorema de pitagoras*/
    public class Ejercicio19
    {
        public void ClasificarTriangulo()
        {
            Console.WriteLine("=== Ejercicio 19: Clasificacion de Triangulos ===");

            Console.Write("Ingrese el lado 1 : ");
            double a = Convert.ToDouble(Console.ReadLine()!);

            Console.Write("Ingrese el lado 2 : ");
            double b = Convert.ToDouble(Console.ReadLine()!);

            Console.Write("Ingrese el lado 3 : ");
            double c = Convert.ToDouble(Console.ReadLine()!);

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("[Error] Los lados deben ser números mayores a cero.");
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("[Error] Los lados ingresados no forman un triángulo válido.");
                return;
            }

            string porLados;
            if (a == b && b == c)
            {
                porLados = "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                porLados = "Isósceles";
            }
            else
            {
                porLados = "Escaleno";
            }

            double mayor = a;
            double otro1 = b;
            double otro2 = c;

            if (b > mayor)
            {
                mayor = b;
                otro1 = a;
                otro2 = c;
            }
            if (c > mayor)
            {
                mayor = c;
                otro1 = a;
                otro2 = b;
            }

            double cuadradoMayor = mayor * mayor;
            double sumaCuadrados = (otro1 * otro1) + (otro2 * otro2);

            string porAngulos;
            if (Math.Abs(cuadradoMayor - sumaCuadrados) < 0.0001)
            {
                porAngulos = "Rectángulo";
            }
            else if (cuadradoMayor < sumaCuadrados)
            {
                porAngulos = "Acutángulo";
            }
            else
            {
                porAngulos = "Obtusángulo";
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine("El triángulo es válido.");
            Console.WriteLine($"Por sus lados:   {porLados}");
            Console.WriteLine($"Por sus ángulos: {porAngulos}");
        }
    }
}