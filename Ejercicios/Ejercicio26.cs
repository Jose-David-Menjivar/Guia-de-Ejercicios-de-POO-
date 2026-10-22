/*Potencia con ciclo - Calcular la base elevada al exponente usando un ciclo (sin Math.Pow).
Considerar exponente 0 y exponentes negativos (resultado con decimales).*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido la base y el exponente valido que cero no tenga exponente negativo y calculo 
    la potencia usando un ciclo for considerando exponentes positivos negativos y cero*/
    public class Ejercicio26
    {
        public void CalcularPotencia()
        {
            Console.WriteLine("===Ejercicio 26: Potencia con ciclo===");

            Console.Write("Ingrese la base : ");
            double baseNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el exponente (entero) : ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            if(baseNumero == 0 && exponente < 0)
            {
                Console.WriteLine("\nERROR: Cero elevado a un exponente negativo no esta definido");
                return;
            }

            int veces = (exponente < 0) ? -exponente : exponente;

            double resultado = 1;
            for (int i = 0; i < veces; i++)
            {
                resultado = resultado * baseNumero;
            }

            if (exponente < 0)
            {
                resultado = 1.0 / resultado;
            }

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"{baseNumero} ^ {exponente} = {resultado}");
        }
    }
}