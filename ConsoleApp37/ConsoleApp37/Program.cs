using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static int[] number = new int[30];
       
        static int a;
        static int b;
        static void LLenado()
        {
            
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Numero de control {0}: ",i+1);
                number[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Procedimiento(int[] number)
        {
            sorteo_mezcla(number,0,number.Length-1);
        }
        static void sorteo_mezcla(int[] number,int desde, int hasta)
        {
            if(desde == hasta)
            {
                return;
            }

            int mitad = (desde +  hasta)/2;

            sorteo_mezcla (number, desde, mitad);
            sorteo_mezcla(number, mitad + 1, hasta);

            int[] auxy = Merge(number, desde, mitad, mitad + 1, hasta);

            Array.Copy(auxy, 0, number, desde, auxy.Length);
        }
        static int[] x;
        static int[] Merge(int[] x,int desde1, int hasta1, int desde2,int hasta2)
        {
            a = desde1;
            b = desde2;

            int[] Mezclando = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for(int i = 0; i < Mezclando.Length;i++)
            {
                if(b != Mezclando.Length)
                {
                    if( a > hasta1 && b<= hasta2)
                    {
                        Mezclando[i] = x[b];
                        b++;

                    }
                    if(b > hasta2 && a<= hasta1 )
                    {
                        Mezclando[i] = x[a];
                        a++;
                    }
                    if(a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            Mezclando[i] = x[b];
                            b++;

                        }
                        else
                        {
                            Mezclando[i] = x[a];
                            a++;
                        }
                    }

                }
                else
                {
                    if(a <= hasta1)
                    {
                        Mezclando[i] = x[a];
                        a++;
                    }
                }
                
            }
            return Mezclando;
        }
        
        static void Imprecion()
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
        static void Main(string[] args)
        {
            LLenado();
            Procedimiento(number);
            Imprecion();
            Console.ReadKey();
        }
    }
}
