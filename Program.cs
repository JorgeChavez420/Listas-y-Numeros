using System;
using System.Collections.Generic;

namespace Listas_y_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numeros = new int[]{ 1, 2, 3, 4, 5};

           numeros[1] = 6;
           numeros[numeros.Length - 1] = 7;
        
        for(int i = 0; i < numeros.Length - 1; i++)
            {
                numeros[i] = numeros[i + 1]; 
            }

           numeros[4] = 8;

           for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]); 
            }
            
            Console.WriteLine("------------");

            List<int> numlist = new List<int>();

            numlist.Add(1);
            numlist.Add(2);
            numlist.Add(3);
            numlist.Add(4);
            numlist.Add(5);

            numlist[1] = 6;
            numlist[numlist.Count - 1] = 7;

            numlist.Remove(0);

            numlist.Add(8);
            numlist.Add(9);

            for(int i = 0; i < numlist.Count; i++)
            {
                numlist[i] = numlist[i] * 3; 
            }



            for(int i = 0; i < numlist.Count; i++)
            {
                if (numlist[i] > 20)
                {
                    numlist.Remove(numlist[i]);
                }  
            }



            for(int i = 0; i < numlist.Count; i++)
            {
                Console.WriteLine(numlist[i]); 
            }

            Console.WriteLine("------------");

            List<int> numlist2 = new List<int>();

            numlist2.Add(2);
            numlist2.Add(6);
            numlist2.Add(19);
            numlist2.Add(34);
            numlist2.Add(65);
            numlist2.Add(12);
            numlist2.Add(42);
            numlist2.Add(33);
            numlist2.Add(40);
            numlist2.Add(15);

            int mayor = numlist2[0];

            for(int i = 0; i < numlist2.Count; i++)
            {
                if (numlist2[i] > mayor) 
                {
                    mayor = numlist2[i];
                }
            }

            Console.WriteLine(" Numero mayor encontrado: " + mayor );
            for(int i = 0; i < numlist2.Count; i++)
            {
                Console.WriteLine(numlist2[i]);
            }


        }
    }
}
