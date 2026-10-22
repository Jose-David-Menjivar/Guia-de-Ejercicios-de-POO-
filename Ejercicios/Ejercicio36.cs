/*Calculadora con menú - Calculadora que opera hasta que el usuario elija salir. Incluir
operaciones básicas, potencia, raíz cuadrada y porcentaje. Mantener el último resultado para
operaciones encadenadas.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*dentro de un ciclo while muestro un menu con las operaciones y se repite hasta que el usuario elija salir, valido la opcion,
    pido el primer numero (si ya hay un resultado anterior le pregunto si quiere usarlo para encadenar operaciones) y el segundo numero cuando hace falta,
    valido la division entre cero, la raiz de un numero negativo y las potencias que no den un numero real, y guardo el ultimo resultado en una variable*/
    public class Ejercicio36
    {
        public void CalculadoraMenu()
        {
            Console.WriteLine("=== Ejercicio 36: Calculadora con menu ===");

            double ultimoResultado = 0;
            bool hayResultado = false;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese la opcion deseada : ");
                int opcion = Convert.ToInt32(Console.ReadLine()!);

                if (opcion < 0 || opcion > 7)
                {
                    Console.WriteLine("ERROR: Opcion no valida, elija una opcion del 0 al 7");
                }
                else if (opcion == 0)
                {
                    continuar = false;
                    Console.WriteLine("Saliendo de la calculadora...");
                }
                else
                {
                    double a = ObtenerPrimerNumero(hayResultado, ultimoResultado);
                    double b = 0;
                    double resultado = 0;
                    bool valido = true;

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el segundo numero : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            resultado = a + b;
                            break;

                        case 2:
                            Console.Write("Ingrese el segundo numero : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            resultado = a - b;
                            break;

                        case 3:
                            Console.Write("Ingrese el segundo numero : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            resultado = a * b;
                            break;

                        case 4:
                            Console.Write("Ingrese el segundo numero : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            if (b == 0)
                            {
                                Console.WriteLine("ERROR: No se puede dividir entre cero");
                                valido = false;
                            }
                            else
                            {
                                resultado = a / b;
                            }
                            break;

                        case 5:
                            Console.Write("Ingrese el exponente : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            resultado = Math.Pow(a, b);
                            if (double.IsNaN(resultado) || double.IsInfinity(resultado))
                            {
                                Console.WriteLine("ERROR: Esa potencia no da un numero real valido");
                                valido = false;
                            }
                            break;

                        case 6:
                            if (a < 0)
                            {
                                Console.WriteLine("ERROR: No existe la raiz cuadrada real de un numero negativo");
                                valido = false;
                            }
                            else
                            {
                                resultado = Math.Sqrt(a);
                            }
                            break;

                        case 7:
                            Console.Write("Ingrese el porcentaje (%) : ");
                            b = Convert.ToDouble(Console.ReadLine()!);
                            resultado = a * b / 100;
                            break;
                    }

                    if (valido)
                    {
                        Console.WriteLine($"Resultado : {resultado}");
                        ultimoResultado = resultado;
                        hayResultado = true;
                    }
                }
            }
        }

        private double ObtenerPrimerNumero(bool hayResultado, double ultimoResultado)
        {
            if (hayResultado)
            {
                Console.Write($"Desea usar el ultimo resultado ({ultimoResultado}) como primer numero? (s/n) : ");
                string respuesta = Console.ReadLine()!.Trim().ToLower();

                if (respuesta == "s")
                {
                    return ultimoResultado;
                }
            }

            Console.Write("Ingrese el primer numero : ");
            return Convert.ToDouble(Console.ReadLine()!);
        }
    }
}
