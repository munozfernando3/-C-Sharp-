using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            Type typeofx= x.GetType();
        }
        public static IEnumerable<int> OnlyEven(int[] list)
        {
          for (int x=0;x<list.Length;x++)
          {
            if (list[x]%2==0)
            yield return list[x];
          }
        }
    }

}