using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Quick_Sort(int[] number ,int primero , int ultimo)
        {
            int i, j, central;
            int pivote , temp;

            central = (primero + ultimo) / 2;

            pivote = number[central];
            i = primero;
            j = ultimo;

            do
            {
                while (number[i] > pivote)
                    i++;
                while (number[j] < pivote)
                    j--;

                if (i <= j)
                {
                    temp = number[i];
                    number[i] = number[j];
                    number[j] = temp;
                    i++;
                    j--;
                }

            } while (i <= j);

            if(primero < j)
            {
                Quick_Sort(number, primero, j);
            }
            if(i < ultimo)
            {
                Quick_Sort(number, i, ultimo);
            }


            

        }
        
        static Random random = new Random();
        static void Main(string[] args)
        {

            int[] number = new int[25];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Desordenado:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
            Console.Clear();

            Quick_Sort(number, 0, number.Length - 1);

            Console.WriteLine("Ordenado:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();

        }
    }
}
