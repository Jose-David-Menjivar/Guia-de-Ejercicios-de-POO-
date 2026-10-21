/*Mayor de tres números - Solicitar tres números diferentes y determinar el mayor usando
operadores lógicos (&&). Mostrar también el menor de los tres.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*Primero pido tres numeros valido que sean distintos usando condicionales y determino el mayor y el menor aplicando operadores logicos*/
    public class Ejercicio12
    {
        public void Mayorde3Numeros()
        {
            Console.WriteLine("=== Ejercicio 11: Mayor de 3 Numeros ===");

            Console.Write("Ingrese el primer Numero : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo Numero : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer Numero : ");
            double c = Convert.ToDouble(Console.ReadLine());

            if(a == b || a == c || b == c)
            {
                Console.WriteLine("ERROR: Los tres numeros deben ser distintos entre si");
                return;
            }

            double mayor;
            if(a > b && a > c)
            {
                mayor = a;
            }

            else if(b > a && b > c)
            {
                mayor = b;
            }

            else
            {
                mayor = c;
            }

            double menor;
            if(a < b && a < c)
            {
                menor = a;
            }

            else if(b < a && b < c)
            {
                menor = b;
            }

            else
            {
                menor = c;
            }

            Console.WriteLine("\n---Resultados---");
            Console.WriteLine($"El numero mayor es : {mayor}");
            Console.WriteLine($"El numero menor es {menor}");
            
        }
    }
}