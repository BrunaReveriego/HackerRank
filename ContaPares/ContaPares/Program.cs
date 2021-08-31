using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaPares
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pares = {36,12, 24, 12, 5, 24, 12,36,42 };
            int n = 6;

            ContaPares(pares, n);


        }

        private static void ContaPares(int[] pares, int n)
        {
            var paresList = pares.ToList();

            int cont = 0;
         
            for (var x = 0; x < paresList.Count; x++)
            {
              
                for(var y= x+1;y< paresList.Count; y++)
                {
                    if(paresList[x] == paresList[y] && (paresList[x] != 0))
                    {
                        paresList[x] = 0;
                        paresList[y] = 0;
                        y = paresList.Count;
                        cont = cont + 1;
                    }
                }

            }
       

            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
