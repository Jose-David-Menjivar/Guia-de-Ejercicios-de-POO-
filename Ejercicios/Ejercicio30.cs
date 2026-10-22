/*30. Factorial y combinaciones - Calcular el factorial de N y luego calcular C(n,r) = n! / (r!(n-r)!) para
valores ingresados.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /* pido n y r valido los rangos calculo el factorial mediante un ciclo for y determino las combinaciones posibles aplicando su formula matematica*/
    public class Ejercicio30
    {
        public void CalcularCombinaciones()
        {
            Console.WriteLine("=== Ejercicio 30: Factorial y combinaciones ===");

            Console.Write("Ingrese el valor de n (0-20): ");
            int n = Convert.ToInt32(Console.ReadLine()!);

            if (n < 0 || n > 20)
            {
                Console.WriteLine("\n[Error] El valor de n debe estar en el rango de 0 a 20.");
                return;
            }

            Console.Write($"Ingrese el valor de r (0 a {n}): ");
            int r = Convert.ToInt32(Console.ReadLine()!);

            if (r < 0 || r > n)
            {
                Console.WriteLine($"\n[Error] El valor de r debe estar entre 0 y {n}.");
                return;
            }

            long factN = CalcularFactorial(n);
            long factR = CalcularFactorial(r);
            long factNR = CalcularFactorial(n - r);

            long combinaciones = factN / (factR * factNR);

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"{n}! = {factN}");
            Console.WriteLine($"C({n}, {r}) = {combinaciones}");
        }

        private long CalcularFactorial(int numero)
        {
            long resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
    }
}