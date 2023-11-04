namespace MyApp // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        public class Item
        {
            protected double _weight;
            protected double _volume;

            public Item(double maxWeight, double maxVolume)
            {
                _weight = maxWeight;
                _volume = maxVolume;
            }
            public Item()
            {

            }

            public double Weight { get => _weight; set => _weight = value; }
            public double Volume { get => _volume; set => _volume = value; }
        }
        public class Arrow : Item
        {
            public Arrow()
            {
                _weight=0.1;
                _volume=0.05;
            }
        }
        public class Bow : Item
        {
            public Bow()
            {
                _weight=1;
                _volume=4;
            }
        }
          public class Rope : Item
        {
            public Rope()
            {
                _weight=1;
                _volume=1.5;
            }
        }
        public class Water : Item
        {
            public Water()
            {
                _weight=2;
                _volume=3;
            }
        }
         public class FoodRations : Item
        {
            public FoodRations()
            {
                _weight=1;
                _volume=0.5;
            }
        }
        public class Sword : Item
        {
            public Sword()
            {
                _weight=5;
                _volume=3;
            }
        }
    }

}