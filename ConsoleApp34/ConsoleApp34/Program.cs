using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static int[] No_Empleado = new int[15];
        

        static void Llenado()
        {
            
           for(int i = 0;  i < No_Empleado.Length; i++)
            {
                Console.Write("Ingresa el numero de Empleado:  ");
                No_Empleado[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Sorteo_Raiz(ref int[] No_Empleado)
        {
            int i, j;

            int[] temp = new int[No_Empleado.Length];

            for ( int shift = 31; shift > -1;shift--)
            {
                j = 0;

                for(i = 0; i < No_Empleado.Length;i++)
                {
                    bool move = (No_Empleado[i] << shift) >= 0;
                    if(shift == 0 ? !move : move)
                    {
                        No_Empleado[i - j] = No_Empleado[i];
                    }
                    else
                    {
                        temp[j++] = No_Empleado[i];
                    }
                    
                }
                Array.Copy(temp, 0, No_Empleado, No_Empleado.Length - j, j);
            }
        }
        static void Main(string[] args)
        {
            

            Llenado();
            Console.WriteLine("\nDesordenado");
            for (int i = 0; i < No_Empleado.Length; i++)
            {
                Console.WriteLine(No_Empleado[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nOrdenado");
            Sorteo_Raiz( ref No_Empleado);
            for (int i = 0; i < No_Empleado.Length; i++)
            {
                Console.WriteLine(No_Empleado[i]);
            }

            Console.ReadKey();

        }
    }
}
