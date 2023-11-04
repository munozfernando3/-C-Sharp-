global using System;
global using static System.Console;
global using static Facilities;
using System.Reflection.Metadata.Ecma335;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Clear();
          var game=new Game();
          game.Start();

        }
    }

}