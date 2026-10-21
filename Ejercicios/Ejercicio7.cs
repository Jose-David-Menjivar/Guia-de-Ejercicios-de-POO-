/*Tiempo transcurrido - Dadas dos horas en formato 24h (hora:minuto:segundo), calcular la
diferencia en horas, minutos y segundos.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    // pido las dos horas con minutos y segundos valido los rangos convierto todo a segundos para calcular la diferencia y lo vuelvo a separar
    public class Ejercicio7
    {
        public void TiempoTranscurrido()
        {
            Console.WriteLine("=== Ejercicio 07: Tiempo transcurrido ===");

            Console.WriteLine("Primera hora:");
            Console.Write("Hora (0-23): ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuto (0-59): ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo (0-59): ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSegunda hora:");
            Console.Write("Hora (0-23): ");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuto (0-59): ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo (0-59): ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            // Validacion de rangos correctos en formato 24h
            if (h1 < 0 || h1 > 23 || m1 < 0 || m1 > 59 || s1 < 0 || s1 > 59 ||
                h2 < 0 || h2 > 23 || m2 < 0 || m2 > 59 || s2 < 0 || s2 > 59)
            {
                Console.WriteLine("[Error] Los datos ingresados estan fuera del rango permitido.");
                return;
            }

            int segundos1 = (h1 * 3600) + (m1 * 60) + s1;
            int segundos2 = (h2 * 3600) + (m2 * 60) + s2;

            int diferencia = segundos2 - segundos1;

            // Si es negativo significa que la segunda hora paso despues de la medianoche.
            if (diferencia < 0)
            {
                diferencia = diferencia + (24 * 3600);
            }

            // Separar de nuevo en horas minutos y segundos
            int horas = diferencia / 3600;
            int minutos = (diferencia % 3600) / 60;
            int segundos = diferencia % 60;

            Console.WriteLine($"\nTiempo transcurrido: {horas} horas, {minutos} minutos y {segundos} segundos.");
        }
    }
}