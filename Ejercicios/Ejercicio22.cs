/*Cajero automático - Simular retiro: verificar que el monto sea múltiplo de 20, no exceda el
saldo (inicializado en código) y mostrar desglose de billetes entregados.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// simulo un retiro bancario valido que el monto sea positivo multiplo de 20 y menor al saldo y calculo el desglose de billetes mediante division y residuo*/
    public class Ejercicio22
    {
        public void RetiroCajero()
        {
            Console.WriteLine("=== Ejercicio 22: Cajero automatico ===");

            double saldo = 5000.00;
            Console.WriteLine($"Saldo disponible : L {saldo:F2}");

            Console.Write("Ingrese el monto a retirar : ");
            int monto = Convert.ToInt32(Console.ReadLine()!);

            if(monto <= 0)
            {
                Console.WriteLine("ERROR: El monto a retirar debe ser mayor a 0");
                return;
            }

            if(monto % 20 != 0)
            {
                Console.WriteLine("ERROR: El monto debe ser Multiplo de 20");
                return;
            }

            if(monto > saldo)
            {
                Console.WriteLine("ERROR: Fondos insuficientes");
                return;
            }

            saldo = saldo - monto;

            int restante = monto;

            int billetes500 = restante / 500;
            restante = restante % 500;

            int billetes100 = restante / 100;
            restante = restante % 100;

            int billetes50 = restante / 50;
            restante = restante % 50;

            int billetes20 = restante / 20;
            restante = restante % 20;

            Console.WriteLine("\n---Retiro Exitoso---");
            Console.WriteLine("Billetes entregados : ");

            if(billetes500 > 0)
            {
                Console.WriteLine($"{billetes500} billete(s) de L 500");
            }
            if (billetes100 > 0)
            {
                Console.WriteLine($"  {billetes100} billete(s) de L 100");
            }
            if (billetes50 > 0)
            {
                Console.WriteLine($"  {billetes50} billete(s) de L 50");
            }
            if (billetes20 > 0)
            {
                Console.WriteLine($"  {billetes20} billete(s) de L 20");
            }

            Console.WriteLine($"\nNuevo saldo: L {saldo:F2}");
        }
    }
}