using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {

        static int[] dato = new int[30];
        static IList<IList<int>> digitos = new List<IList<int>>();
        public static  int tamax = 0;
        public static void  LimpiarDigitos()
        {
            for (int i = 0; i < digitos.Count; i++) {

                digitos[i].Clear();
            
            }
        }
        public static void MostrarDatos()
        {
            for(int i = 0;i < dato.Length;i++)
            {
                Console.WriteLine(dato[i]);
            }
        }
        public static void soteo_radiz()
        {
            for (int i = 0; i < tamax; i++)
            {
                for(int j = 0; j < dato.Length; j++)
                {
                    int digito = (int)((dato[j] % Math.Pow(10, i + 1)) / Math.Pow(10, i));

                    digitos[digito].Add(dato[j]);
                }
                int indice = 0;
                for(int y = 0; y < digitos.Count;y++)
                {
                    IList<int> seldigito = digitos[y];
                    for(int x = 0; x < seldigito.Count;x++)
                    {
                        dato[indice++] = seldigito[x];
                    }
                }
                LimpiarDigitos();
            }
            MostrarDatos();
        }

        static Random Random = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < dato.Length; i++)
            {
                digitos.Add(new List<int>());
            }

            for (int i = 0;i < dato.Length; i++)
            {
                dato[i] = Random.Next(1, 100);

                //obteniendo los digitos
                if(tamax < dato[i].ToString().Length)
                {
                    tamax = dato[i].ToString().Length;
                }
            }

            soteo_radiz();
            Console.ReadKey();
            
        }
    }
}
