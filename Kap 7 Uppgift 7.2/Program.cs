using System;
using System.Collections.Generic;

namespace Uppgift7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(90);
            list.Add(-56);
            list.Add(45);
            list.Add(78);
            list.Add(234);

            Console.WriteLine(Max(list));
        }

        /// <summary>
        /// Returnerar en listas största värde
        /// </summary>
        /// <param name="list">Listan som ska kollas.</param>
        /// <returns></returns>
        static int Max(List<int> list)
        {
            int max = int.MinValue;
            foreach (int nr in list)
            {
                if (nr > max) max = nr;
            }
            return max;
        }
    }
}

/*Skapa ett program som har en metod som heter Max. Metoden ska ha
en List&lt;int&gt; som parameter och ska returnera det största talet som finns i listan.*/