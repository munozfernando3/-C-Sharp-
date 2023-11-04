global using System;
global using static Facilities;
global using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Pack pack=new Pack(5,20,10);
           Menu menu= new Menu("Pack",pack.DisplayStatusMessage, "Sword", "Bow", "Rope", "Food Rations", "Water");
           while (true)
           {
            Clear();
            pack.DisplayStatusMessage();
            menu.Display();
            if (menu.SelectedOption(1))
            {
                pack.Add(new Sword());
            }
            if (menu.SelectedOption(2))
            {
                pack.Add(new Bow());
            }
             if (menu.SelectedOption(3))
            {
                pack.Add(new Rope());
            }
             if (menu.SelectedOption(4))
            {
                pack.Add(new FoodRations());
            }
         if (menu.SelectedOption(5))
            {
                pack.Add(new Water());
            }
           }
            


        }
    }
}