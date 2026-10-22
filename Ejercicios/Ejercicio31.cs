/*MCD y MCM - Calcular el máximo común divisor de dos números usando el algoritmo de
Euclides (while) y, a partir de él, obtener el mínimo común múltiplo.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido dos numeros enteros positivos calculo el mcd mediante el algoritmo de euclides con un ciclo while y obtengo el mcm con su formula matematica*/
    public class Ejercicio31
    {
        public void CalcularMcdYcm()
        {
            Console.WriteLine("=== Ejercicio 31: MCD y MCM ===");

            Console.Write("Ingrese el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Ingrese el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine()!);

            if (numero1 <= 0 || numero2 <= 0)
            {
                Console.WriteLine("\n[Error] Ambos números deben ser enteros mayores a cero.");
                return;
            }

            long a = numero1;
            long b = numero2;

            while (b != 0)
            {
                long temporal = b;
                b = a % b;
                a = temporal;
            }

            long mcd = a;

            long mcm = ((long)numero1 * numero2) / mcd;

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"MCD de {numero1} y {numero2} = {mcd}");
            Console.WriteLine($"MCM de {numero1} y {numero2} = {mcm}");
        }
    }
}