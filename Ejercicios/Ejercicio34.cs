/*Validación de contraseña - Solicitar contraseña hasta que cumpla: mínimo 8 caracteres, al
menos una mayúscula, una minúscula, un número y un carácter especial. Indicar qué falta en
cada intento.*/

namespace Guia_de_Ejercicios_de_POO.Ejercicios
{
    /*pido la contraseña dentro de un ciclo while que se repite hasta que sea valida, recorro la contraseña caracter por caracter con un foreach
    para saber si tiene mayuscula, minuscula, numero o caracter especial, y reviso que tenga minimo 8 caracteres,
    si algo falta le muestro al usuario que es lo que falta en ese intento*/
    public class Ejercicio34
    {
        public void ValidarContrasena()
        {
            Console.WriteLine("=== Ejercicio 34: Validacion de contraseña ===");
            Console.WriteLine("Requisitos: minimo 8 caracteres, una mayuscula, una minuscula, un numero y un caracter especial");

            bool valida = false;

            while (valida == false)
            {
                Console.Write("\nIngrese la contraseña : ");
                string contrasena = Console.ReadLine()!;

                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                foreach (char c in contrasena)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        tieneMayuscula = true;
                    }
                    else if (c >= 'a' && c <= 'z')
                    {
                        tieneMinuscula = true;
                    }
                    else if (c >= '0' && c <= '9')
                    {
                        tieneNumero = true;
                    }
                    else
                    {
                        tieneEspecial = true;
                    }
                }

                bool largoCorrecto = contrasena.Length >= 8;

                if (largoCorrecto && tieneMayuscula && tieneMinuscula && tieneNumero && tieneEspecial)
                {
                    valida = true;
                    Console.WriteLine("\nContraseña valida");
                }
                else
                {
                    Console.WriteLine("Contraseña invalida, le falta:");
                    if (largoCorrecto == false)
                    {
                        Console.WriteLine("- Minimo 8 caracteres");
                    }
                    if (tieneMayuscula == false)
                    {
                        Console.WriteLine("- Una letra mayuscula");
                    }
                    if (tieneMinuscula == false)
                    {
                        Console.WriteLine("- Una letra minuscula");
                    }
                    if (tieneNumero == false)
                    {
                        Console.WriteLine("- Un numero");
                    }
                    if (tieneEspecial == false)
                    {
                        Console.WriteLine("- Un caracter especial");
                    }
                }
            }
        }
    }
}
