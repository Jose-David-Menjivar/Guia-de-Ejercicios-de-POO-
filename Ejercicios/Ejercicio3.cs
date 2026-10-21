/*Intercambio de valores - Declarar dos variables con valores iniciales, intercambiar sus valores
usando una variable temporal y mostrar el antes y el después. Reto adicional: hacerlo sin
variable temporal, usando solo operaciones aritméticas.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*primero declaro las dos variables y las intercambio con una variable temporal y 
    luego hago el reto intercambiandolas solo con suma y resta*/
    public class Ejercicio3
    {
        public void Intercambio()
        {
            Console.WriteLine("=== Ejercicio 03: Intercambio de valores ===");

            int a = 10;
            int b = 25;

            Console.WriteLine("Con variable temporal");
            Console.WriteLine($"Antes: a = {a}, b = {b}");

            int temporal = a;
            a = b;
            b = temporal;

            Console.WriteLine($"Después: a = {a}, b = {b}");

            a = 10;
            b = 25;
            Console.WriteLine();
            Console.WriteLine("Sin variable temporal (reto)");
            Console.WriteLine($"Antes: a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Después : a = {a}, b = {b}");
        }
    }
}