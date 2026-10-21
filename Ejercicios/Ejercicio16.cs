/*Sistema de calificaciones UNAH - Ingresar nota de 0-100 y mostrar: letra (A, B, C, D, F),
descripción y si aprobó o reprobó. Incluir validación de rango.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*// pido una calificacion de 0 a 100 valido el rango determino la letra y descripcion con condicionales y muestro si aprobo o reprobo usando el operador ternario0*/
    public class Ejercicio16
    {
        public void SistemaCalificaciones()
        {
            Console.WriteLine("=== Ejercicio 16: Sistema de Calificaciones UNAH ===");
            
            Console.Write("Ingrese la nota (0-100) : ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("ERROR: La nota debe estar en el rango de 0 a 100");
                return;
            }

            string letra;
            string descripcion;

            if(nota >= 0)
            {
                letra = "A";
                descripcion = "Excelente";
            }
            else if (nota >= 80)
            {
                letra = "B";
                descripcion = "Muy bueno";
            }
            else if (nota >= 70)
            {
                letra = "C";
                descripcion = "Bueno";
            }
            else if (nota >= 65)
            {
                letra = "D";
                descripcion = "Suficiente";
            }
            else
            {
                letra = "F";
                descripcion = "Insuficiente";
            }

            // Operador ternario para saber si aprobo o reprobo
            string estado = (nota >= 65) ? "APROBÓ" : "REPROBÓ";

            Console.WriteLine("\n--- Resultado de Calificación ---");
            Console.WriteLine($"Nota: {nota:F1}");
            Console.WriteLine($"Calificación: {letra}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}