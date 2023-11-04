using System;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            WriteLine("Old Array ");
            DisplayArrayValues(array);
            WriteLine("New Array");
            DisplayArrayValues(Query.GetNewArrayWithConditions(array));
            //       WriteLine("New Array");
            // DisplayArrayValues(Procedural.FilterOdddNumbers(array));
        }
        static void DisplayArrayValues(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Write(array[x] + " ");
            }
            WriteLine(" ");
        }
       
        
        }
        public static class Query
        {
            public static int[] GetNewArrayWithConditions(int[] array)
            {
                var EvenOrderedDoubledNumbers = from o in array
                                      where o % 2 == 0
                                      orderby o
                                      select o*2;
                int[] newArray = EvenOrderedDoubledNumbers.ToArray<int>();
                return newArray;
            }
        }
    }
}