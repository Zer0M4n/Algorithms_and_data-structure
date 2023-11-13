using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Ingresar_datos()
        {

            for (int i = 0; i < vector.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Ingresa la calificacion {i + 1} entre 1 y 100: ");
                    if (float.TryParse(Console.ReadLine(), out vector[i]) && vector[i] >= 1 && vector[i] <= 100)
                    {
                        Console.WriteLine($"Número válido: {vector[i]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El número debe estar dentro del rango de 1 a 100. Intenta de nuevo.");
                    }
                }
            }
        }
        static void Algoritmo_shell()
        {
            byte  bandera = 0, contador = 0;
            int salto = vector.Length / 2;
            float auxl = 0;


            while (salto > 0)
            {
                bandera = 1;
                while (bandera != 0)
                {
                    bandera = 0;
                    contador = 1;
                    while (contador <= (vector.Length - salto))
                    {
                        if (vector[contador - 1] > vector[(contador - 1) + salto])
                        {
                            auxl = vector[(contador - 1) + salto];
                            vector[(contador - 1) + salto] = vector[contador - 1];
                            vector[contador - 1] = auxl;
                            bandera = 1;
                        }
                        contador++;
                    }
                }
                salto = salto / 2;
            }
            

        }
        static void Mostra_Datos()
        {
            Ingresar_datos();
            Algoritmo_shell();
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static float[] vector = new float[15];
        static void Main(string[] args)
        {
            Mostra_Datos();
            Console.ReadKey();
        }
    }
}
