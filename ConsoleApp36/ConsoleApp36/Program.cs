using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static int[] Numbers = new int[15];
        static int[] Numbers2 = new int[11];
        
        static void Llenado()
        {
            Random rnd = new Random();
            for (byte i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(0,100);
            }
            for (byte i = 0; i < Numbers2.Length; i++)
            {
                Numbers2[i] = rnd.Next(0,100);
            }

        }


        static void Quick_Sort(int[] Numbers, int primero, int ultimo)
        {
            int i, j, central;
            int pivote, temp;
            central = (primero + ultimo) / 2;
            pivote = Numbers[central];
            i = primero;
            j = ultimo;
            do
            {
                while (Numbers[i] < pivote)
                    i++;
                while (Numbers[j] > pivote)
                    j--;
                if (i <= j)
                {
                    temp = Numbers[i];
                    Numbers[i] = Numbers[j];
                    Numbers[j] = temp;
                    i++;
                    j--;
                }

            } while (i <= j);
            if (primero < j)
            {
                Quick_Sort(Numbers, primero, j);
            }
            if (i < ultimo)
            {
                Quick_Sort(Numbers, i, ultimo);
            }

        }

        static void Quick_Sort2(int[] Numbers2, int primero, int ultimo)
        {
            int i, j, central;
            int pivote, temp;
            central = (primero + ultimo) / 2;
            pivote = Numbers2[central];
            i = primero;
            j = ultimo;
            do
            {
                while (Numbers[i] < pivote)
                    i++;
                while (Numbers2[j] > pivote)
                    j--;
                if (i <= j)
                {
                    temp = Numbers2[i];
                    Numbers2[i] = Numbers2[j];
                    Numbers2[j] = temp;
                    i++;
                    j--;
                }

            } while (i <= j);
            if (primero < j)
            {
                Quick_Sort(Numbers2, primero, j);
            }
            if (i < ultimo)
            {
                Quick_Sort(Numbers2, i, ultimo);
            }

        }

        static void Imprecionn()
        {
            Console.WriteLine("Arrglo 1 \n");
            for (byte i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Arrglo 2 \n");
            for (byte i = 0; i < Numbers2.Length; i++)
            {
                Console.WriteLine(Numbers2[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void intercalacion_Simple()
        {
            Llenado();
            Console.WriteLine("Arrglo  Desordenado\n");
            Imprecionn();
            Quick_Sort(Numbers,0,Numbers.Length-1);
            Quick_Sort2(Numbers2, 0, Numbers2.Length - 1);
            Console.WriteLine("Arrglo  Ordenado\n");
            Imprecionn();
            int N = Numbers.Length;
            int M = Numbers2.Length;

            int[] Numbers3 = new int[M + N];
            int i = 0 , j = 0 , k = 0 ;

            while(i < N && j < M) 
            {
                if (Numbers[i] <= Numbers2[j]) 
                {
                    Numbers3[k] = Numbers[i];
                    i++;
                }
                else
                {
                    Numbers3[k] = Numbers2[j];
                    j++;

                }

                k++;
            }

            if(i == N)
            {
                for(int p = j; p < M; p++) 
                {
                    Numbers3[k] = Numbers2[p];
                    k++;
                }
            }
            else
            {
                for(int p = i; p < N;p++)
                {
                    Numbers3[k] = Numbers[p];
                    k++;
                }
            }

            Console.WriteLine("Arreglo ordenado con el metodo 2");
            for (int i1 = 0; i1 < Numbers3.Length; i1++)
            {
                Console.WriteLine(Numbers3[i1]);
            }
        }



        static void Main(string[] args)
        {
            intercalacion_Simple();
            Console.ReadKey();
        }
    }
}
