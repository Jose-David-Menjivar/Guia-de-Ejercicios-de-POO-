/*Desglose de billetes - Dado un monto en lempiras, mostrar la menor cantidad de billetes (500,
100, 50, 20, 10, 5, 2, 1) necesarios.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /**/
    public class Ejercicio8
    {
        public void DesgloseBilletes()
        {
            Console.WriteLine("=== Ejercicio 08: Desglose de Billetes");
            Console.Write("Ingrese el monto en lempiras : ");
            int monto = Convert.ToInt32(Console.ReadLine());

            if(monto <= 0)
            {
                Console.WriteLine("ERROR: El monto debe ser un número entero mayor a 0");
                return;
            }

            Console.WriteLine("\n---Desglose de Biletes---");

            int billetes500 = monto / 500;
            monto %= 500;

            int billetes100 = monto / 100;
            monto %= 100;

            int billetes50 = monto / 50;
            monto %= 50;

            int billetes20 = monto / 20;
            monto %= 20;

            int billetes10 = monto / 10;
            monto %= 10;

            int billetes5 = monto / 5;
            monto %= 5;

            int billetes2 = monto / 2;
            monto %= 2;

            int billetes1 = monto;

            if(billetes500 > 0) Console.WriteLine($"{billetes500} billetes de L 500");
            if (billetes100 > 0) Console.WriteLine($"{billetes100} billete(s) de L 100");
            if (billetes50 > 0)  Console.WriteLine($"{billetes50} billete(s) de L 50");
            if (billetes20 > 0)  Console.WriteLine($"{billetes20} billete(s) de L 20");
            if (billetes10 > 0)  Console.WriteLine($"{billetes10} billete(s) de L 10");
            if (billetes5 > 0)   Console.WriteLine($"{billetes5} billete(s) de L 5");
            if (billetes2 > 0)   Console.WriteLine($"{billetes2} billete(s) de L 2");
            if (billetes1 > 0)   Console.WriteLine($"{billetes1} billete(s) de L 1");
        }
    }
}