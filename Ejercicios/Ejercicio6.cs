/*Suma de dígitos - Dado un número entero positivo de tres dígitos, calcular la suma de sus
dígitos usando únicamente división entera y módulo (sin ciclos ni conversión a texto).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    // pido un numero positivo de tres digitos valido que este en el rango de 100 a 999 y sumo sus digitos usando solo division y residuo
    public class Ejercicio6
    {
        public void SumaDeDigitos()
        {
            Console.WriteLine("=== Ejercicio 06: Suma de digitos ===");
            Console.Write("Ingrese un número entero positivo de tres dígitos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Validacion de 3 digitos positivos (100 a 999)
            if (numero < 100 || numero > 999)
            {
                Console.WriteLine("[Error] Debe ingresar exactamente un número positivo de 3 dígitos (entre 100 y 999).");
                return;
            }

            int suma = 0;
            suma += numero % 10; // Dígito de las unidades
            numero /= 10;
            suma += numero % 10; // Dígito de las decenas
            numero /= 10;
            suma += numero % 10; // Dígito de las centenas

            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }
    }
}