/*Juego de adivinanza - El programa genera un número aleatorio (1-100). El usuario tiene 7
intentos con pistas de "mayor" o "menor". Mostrar estadísticas al final.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*genero un numero aleatorio del 1 al 100 y le doy al usuario 7 intentos con un ciclo while, en cada intento valido que el numero este entre 1 y 100
    (si no lo esta no cuenta como intento), le doy la pista de mayor o menor y cuento las pistas, el ciclo termina si acierta o si se acaban los intentos
    y al final muestro las estadisticas*/
    public class Ejercicio33
    {
        public void JuegoAdivinanza()
        {
            Console.WriteLine("=== Ejercicio 33: Juego de adivinanza ===");
            Console.WriteLine("Adivine el numero entre 1 y 100. Tiene 7 intentos.");

            Random aleatorio = new Random();
            int secreto = aleatorio.Next(1, 101);

            int intentos = 0;
            bool acerto = false;
            int pistasMayor = 0;
            int pistasMenor = 0;

            while (intentos < 7 && acerto == false)
            {
                Console.Write($"\nIntento {intentos + 1} de 7 : ");
                int numero = Convert.ToInt32(Console.ReadLine()!);

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("ERROR: El numero debe estar entre 1 y 100. Ese intento no cuenta.");
                }
                else
                {
                    intentos++;

                    if (numero == secreto)
                    {
                        acerto = true;
                    }
                    else if (numero < secreto)
                    {
                        Console.WriteLine("Pista: el numero secreto es MAYOR");
                        pistasMayor++;
                    }
                    else
                    {
                        Console.WriteLine("Pista: el numero secreto es MENOR");
                        pistasMenor++;
                    }
                }
            }

            Console.WriteLine("\n--- Resultado del juego ---");
            if (acerto)
            {
                Console.WriteLine($"Felicidades, adivino el numero {secreto}");
            }
            else
            {
                Console.WriteLine($"Se acabaron los intentos, el numero era {secreto}");
            }

            Console.WriteLine("\n--- Estadisticas ---");
            Console.WriteLine($"Intentos usados : {intentos}");
            Console.WriteLine($"Pistas de mayor : {pistasMayor}");
            Console.WriteLine($"Pistas de menor : {pistasMenor}");
            Console.WriteLine("Resultado : " + (acerto ? "Gano" : "Perdio"));
        }
    }
}
