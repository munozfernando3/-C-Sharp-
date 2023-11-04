global using static System.Console;
global using static System.ConsoleColor;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clear();
            ColoredType<Sword> yellowSword= new ColoredType<Sword>(new Sword(), Yellow);
            ColoredType<Axe> greenAxe= new ColoredType<Axe>(new Axe(), Green);
            ColoredType<Bow> blueBow= new ColoredType<Bow>(new Bow(), Blue);
            yellowSword.Display();
            greenAxe.Display();
            blueBow.Display();
        }
    }
    public class Sword
    {
        private string _name = "Sword";
        public override string ToString()
        {
          return _name;
        }
        
    }
        public class Bow
    {
        private string _name = "Bow";
        public override string ToString()
        {
            return _name;
        }
    }
    public class Axe
    {
        private string _name = "Axe";
        public override string ToString()
        {
            return _name;
        }
    }
    public class ColoredType<T>
    {
        private T _item;
        private ConsoleColor _color;

        public ColoredType(T item, ConsoleColor color)
        {
            _item = item;
            _color = color;
        }

        public void Display()
        {
            ForegroundColor= _color;
            WriteLine(_item.ToString());
            ResetColor();
        }  
    }
}