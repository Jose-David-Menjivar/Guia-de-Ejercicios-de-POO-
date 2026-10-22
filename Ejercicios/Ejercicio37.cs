/*Registro de números - Leer N números enteros en un arreglo. Recorrerlo con for y con foreach
para calcular la suma, el promedio, el valor mayor y el menor.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido la cantidad N de numeros valido que sea positiva y los guardo en un arreglo con un ciclo for, luego recorro el arreglo una vez con for
    y otra vez con foreach calculando en cada recorrido la suma, el mayor y el menor, el promedio sale de dividir la suma entre N y muestro los resultados de las dos formas*/
    public class Ejercicio37
    {
        public void RegistroNumeros()
        {
            Console.WriteLine("=== Ejercicio 37: Registro de numeros ===");

            Console.Write("Cuantos numeros desea ingresar : ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n <= 0)
            {
                Console.WriteLine("ERROR: La cantidad debe ser un numero entero mayor a 0");
                return;
            }

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el numero {i + 1} : ");
                numeros[i] = Convert.ToInt32(Console.ReadLine()!);
            }

            int sumaFor = 0;
            int mayorFor = numeros[0];
            int menorFor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                sumaFor += numeros[i];
                if (numeros[i] > mayorFor)
                {
                    mayorFor = numeros[i];
                }
                if (numeros[i] < menorFor)
                {
                    menorFor = numeros[i];
                }
            }

            int sumaForeach = 0;
            int mayorForeach = numeros[0];
            int menorForeach = numeros[0];

            foreach (int numero in numeros)
            {
                sumaForeach += numero;
                if (numero > mayorForeach)
                {
                    mayorForeach = numero;
                }
                if (numero < menorForeach)
                {
                    menorForeach = numero;
                }
            }

            double promedioFor = (double)sumaFor / n;
            double promedioForeach = (double)sumaForeach / n;

            Console.WriteLine("\n--- Resultados con for ---");
            Console.WriteLine($"Suma : {sumaFor}");
            Console.WriteLine($"Promedio : {promedioFor:F2}");
            Console.WriteLine($"Mayor : {mayorFor}");
            Console.WriteLine($"Menor : {menorFor}");

            Console.WriteLine("\n--- Resultados con foreach ---");
            Console.WriteLine($"Suma : {sumaForeach}");
            Console.WriteLine($"Promedio : {promedioForeach:F2}");
            Console.WriteLine($"Mayor : {mayorForeach}");
            Console.WriteLine($"Menor : {menorForeach}");
        }
    }
}
