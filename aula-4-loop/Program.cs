using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_4_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var a = 1;
              while (a < 5)
             {
                 Console.WriteLine(a);
                 a++;

             } */
            /*  for (int a = 1; a < 5; a++)
                 {
                     Console.WriteLine("a menor que 5");
                 }*/



            /*   ========================== */



            /*  int[] a = { 1, 2, 3 };

              foreach(int v in a)
              {
                  Console.WriteLine(v);
              }

             for (int i = 0; i < a.Length; i++)
              {
                  Console.WriteLine(a[i]);
              }


              Console.Read(); */

            looping(1);
        }


        public static void looping (int a)
        {
            Console.WriteLine(a);
            if (a < 3)
            {
                looping(a + 1);
            }
        }
    }
}
