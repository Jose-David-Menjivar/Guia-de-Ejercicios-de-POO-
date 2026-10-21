/*Día de la semana - Solicitar un número del 1 al 7 y mostrar el nombre del día correspondiente
usando switch clásico; luego resolverlo de nuevo usando una expresión switch.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido un numero del 1 al 7 valido el rango y muestro el dia de la semana correspondiente usando primero switch tradicional y luego switch expression*/
    public class Ejercicio13
    {
        public void DiasdelaSemana()
        {
            Console.WriteLine("=== Ejercicio 13: Dias de la Semana ===");

            Console.Write("Ingrese un Numero del 1 al 7 : ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero < 1 || numero > 7)
            {
                Console.WriteLine("ERROR : EL numero debe estar entre 1 y 7");
                return;
            }

            string Dia = "";

            switch (numero)
            {
                case 1:
                     Dia = "Lunes";
                     break;
                
                case 2:
                     Dia = "Martes";
                     break;

                case 3:
                     Dia = "Miercoles";
                     break;

                case 4: 
                     Dia = "Jueves";
                     break;

                case 5: 
                     Dia = "Viernes";
                     break;

                case 6:
                     Dia = "Sabado";
                     break;

                case 7:
                     Dia = "Domingo";
                     break;

                default:
                     Dia = "Opcion Invalida";
                     break;
            }

            string DiaExpresion = numero switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miercoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sabado",
                7 => "Domingo",
                _ => "Opcion Invalida"
            };

            Console.WriteLine("\n---Resultados---");
            Console.WriteLine($"Switch clasico: {Dia}");
            Console.WriteLine($"Expresion switch: {DiaExpresion}");
        }
    }
}