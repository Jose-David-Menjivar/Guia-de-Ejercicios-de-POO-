/*Números primos en rango - Dado un rango (inicio, fin), mostrar todos los números primos y
contar cuántos hay.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido el inicio y el fin del rango valido que el inicio no sea negativo, que el fin no pase de 1000000 y que no sea menor al inicio,
    recorro cada numero del rango con un ciclo for y compruebo si es primo probando divisores con otro ciclo for,
    muestro los primos que encuentro y cuento cuantos hay*/
    public class Ejercicio32
    {
        public void PrimosEnRango()
        {
            Console.WriteLine("=== Ejercicio 32: Numeros primos en rango ===");

            Console.Write("Ingrese el inicio del rango : ");
            int inicio = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Ingrese el fin del rango : ");
            int fin = Convert.ToInt32(Console.ReadLine()!);

            if (inicio < 0 || fin > 1000000)
            {
                Console.WriteLine("ERROR: El inicio no puede ser negativo y el fin no puede ser mayor a 1000000");
                return;
            }

            if (fin < inicio)
            {
                Console.WriteLine("ERROR: El fin debe ser mayor o igual al inicio");
                return;
            }

            int cantidad = 0;

            Console.WriteLine($"\n--- Primos entre {inicio} y {fin} ---");
            for (int numero = inicio; numero <= fin; numero++)
            {
                bool esPrimo = numero >= 2;

                for (int divisor = 2; divisor * divisor <= numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.Write(numero + " ");
                    cantidad++;
                }
            }

            Console.WriteLine("\n\n--- Resultados ---");
            Console.WriteLine($"Total de primos : {cantidad}");
        }
    }
}
