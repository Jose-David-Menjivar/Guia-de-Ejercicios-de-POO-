/*Patrones en consola - Menú para generar patrones: triángulo, triángulo invertido, rombo,
cuadrado hueco y pirámide numérica. El usuario define el tamaño.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*muestro un menu con los cinco patrones, pido el tamaño y valido que este entre 1 y 30 (la piramide numerica solo de 1 a 9 para que sean digitos),
    y con un switch dibujo el patron elegido usando ciclos for anidados donde el ciclo de afuera son las filas y los de adentro
    los espacios, asteriscos o numeros de cada fila*/
    public class Ejercicio35
    {
        public void PatronesConsola()
        {
            Console.WriteLine("=== Ejercicio 35: Patrones en consola ===");
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. Triangulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine("5. Piramide numerica");
            Console.Write("Ingrese el numero de la opcion deseada : ");
            int opcion = Convert.ToInt32(Console.ReadLine()!);

            if (opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opcion no valida.");
                return;
            }

            Console.Write("Ingrese el tamaño del patron : ");
            int tamano = Convert.ToInt32(Console.ReadLine()!);

            if (tamano < 1 || tamano > 30)
            {
                Console.WriteLine("ERROR: El tamaño debe estar entre 1 y 30");
                return;
            }

            if (opcion == 5 && tamano > 9)
            {
                Console.WriteLine("ERROR: La piramide numerica solo admite tamaños de 1 a 9");
                return;
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    for (int fila = 1; fila <= tamano; fila++)
                    {
                        for (int estrella = 1; estrella <= fila; estrella++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (int fila = tamano; fila >= 1; fila--)
                    {
                        for (int estrella = 1; estrella <= fila; estrella++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int fila = 1; fila <= tamano; fila++)
                    {
                        for (int espacio = 1; espacio <= tamano - fila; espacio++)
                        {
                            Console.Write(" ");
                        }
                        for (int estrella = 1; estrella <= 2 * fila - 1; estrella++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int fila = tamano - 1; fila >= 1; fila--)
                    {
                        for (int espacio = 1; espacio <= tamano - fila; espacio++)
                        {
                            Console.Write(" ");
                        }
                        for (int estrella = 1; estrella <= 2 * fila - 1; estrella++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:
                    for (int fila = 1; fila <= tamano; fila++)
                    {
                        for (int columna = 1; columna <= tamano; columna++)
                        {
                            if (fila == 1 || fila == tamano || columna == 1 || columna == tamano)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    for (int fila = 1; fila <= tamano; fila++)
                    {
                        for (int espacio = 1; espacio <= tamano - fila; espacio++)
                        {
                            Console.Write(" ");
                        }
                        for (int numero = 1; numero <= fila; numero++)
                        {
                            Console.Write(numero);
                        }
                        for (int numero = fila - 1; numero >= 1; numero--)
                        {
                            Console.Write(numero);
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
