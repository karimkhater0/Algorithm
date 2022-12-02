using System;
using System.Collections.Generic;


namespace Insertion_Sort
{
    class insertion_Sort
    {
        static void Main(string[] args)
        {

           

            List<int> l = new List<int>{ 5, 22, 8, 4, 1, 25 };
            Console.WriteLine("Before sorting:");
            l.ForEach(Console.WriteLine);
            Console.WriteLine("After sorting:");
            insertionSort(l);
            l.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        static List<int>  insertionSort(List<int> list)
        {
            for (int j = 1; j < list.Count; j++)
            {
                int key = list[j];

                int i = j - 1;

                while (i >= 0 && list[i] > key)
                {
                    list[i + 1] = list[i];
                    i = i - 1;
                    list[i + 1] = key;
                }
            }
            return list;
        }
        }
}
