using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static int[] number = new int[25];

        static void LLenado()
        {
            
            for (byte i = 0; i < number.Length; i++)
            {
                Console.Write("Cual fue su calificacion? ");
                number[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Imprecion()
        {
            Console.WriteLine("Desordenado\n");
            for (byte i = 0;i < number.Length;i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Intercalacion_Sumple();

            Console.WriteLine("Ordenado\n");
            for (byte i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        static void Intercalacion_Sumple()
        {
            int N = number.Length;
            int i, j, izq, der, mitad, auxi;
            for (i = 0; i < N; i++)
            {
                auxi = number[i];
                izq = 0; der = i-1;

                while ( izq <= der)
                {
                    mitad = (izq + der) / 2;
                    if(auxi >= number[mitad])
                    {
                        der = mitad - 1;
                    }
                    else
                    {
                        izq = mitad + 1;
                    }
                }
                j = i-1;
                while ( j >= izq )
                {
                    number[j +1] = number[j];
                    j--;
                }
                number[izq] = auxi;

            }
        }
        static void Main(string[] args)
        {
            LLenado();
            
            Imprecion();
            Console.ReadKey();
        }
    }
}
