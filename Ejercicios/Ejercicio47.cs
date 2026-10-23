/*Registro de calificaciones - Almacenar notas en una List<double> hasta que el usuario decida
parar. Calcular promedio, nota máxima y mínima; luego eliminar la nota más baja y recalcular el
promedio.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido notas validando que esten entre 0 y 100 y las guardo en una List<double> dentro de un ciclo while que se repite mientras el usuario responda s,
    calculo el promedio, la nota maxima y la minima recorriendo la lista, luego busco la posicion de la nota mas baja y la elimino con RemoveAt
    (solo si hay mas de una nota) y vuelvo a calcular los resultados, para no repetir el codigo uso un metodo que calcula y muestra las estadisticas*/
    public class Ejercicio47
    {
        public void RegistroCalificaciones()
        {
            Console.WriteLine("=== Ejercicio 47: Registro de calificaciones ===");

            List<double> notas = new List<double>();
            string continuar = "s";

            while (continuar == "s")
            {
                Console.Write("Ingrese una nota (0-100) : ");
                double nota = Convert.ToDouble(Console.ReadLine()!);

                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("ERROR: La nota debe estar en el rango de 0 a 100");
                }
                else
                {
                    notas.Add(nota);

                    Console.Write("Desea agregar otra nota? (s/n) : ");
                    continuar = Console.ReadLine()!.Trim().ToLower();
                }
            }

            MostrarEstadisticas(notas, "Estadisticas iniciales");

            if (notas.Count < 2)
            {
                Console.WriteLine("\nSolo hay una nota, no se puede eliminar la mas baja");
                return;
            }

            int posicionMenor = 0;
            for (int i = 1; i < notas.Count; i++)
            {
                if (notas[i] < notas[posicionMenor])
                {
                    posicionMenor = i;
                }
            }

            Console.WriteLine($"\nSe elimina la nota mas baja : {notas[posicionMenor]:F2}");
            notas.RemoveAt(posicionMenor);

            MostrarEstadisticas(notas, "Estadisticas sin la nota mas baja");
        }

        private void MostrarEstadisticas(List<double> notas, string titulo)
        {
            double suma = 0;
            double mayor = notas[0];
            double menor = notas[0];

            foreach (double nota in notas)
            {
                suma += nota;

                if (nota > mayor)
                {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }

            double promedio = suma / notas.Count;

            Console.WriteLine($"\n--- {titulo} ---");
            Console.WriteLine($"Cantidad de notas : {notas.Count}");
            Console.WriteLine($"Promedio : {promedio:F2}");
            Console.WriteLine($"Nota maxima : {mayor:F2}");
            Console.WriteLine($"Nota minima : {menor:F2}");
        }
    }
}
