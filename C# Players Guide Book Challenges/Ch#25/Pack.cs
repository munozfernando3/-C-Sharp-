namespace MyApp // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        public class Pack
        {
            private Item[] _items;
            private double _currentVolume;
            private double _currentWeight;
            private int _currentItems;
            private int _maxNumberOftems;

            private double _maxWeight;

            private double _maxVolume;

            public Pack(int maxNumberOftems, int maxWeight, int maxVolume)
            {
                _maxNumberOftems = maxNumberOftems;
                _maxVolume = maxVolume;
                _maxWeight = maxWeight;
                _items = new Item[_maxNumberOftems];
                _currentItems = 0;
                _currentVolume = 0;
                _currentWeight = 0;
            }




            public void Add(Item item)
            {

                if (EnsureQuantity(_currentItems, 1, _maxNumberOftems) &&EnsureQuantity(_currentVolume,item.Volume, _maxVolume) &&EnsureQuantity(_currentWeight,item.Weight, _maxWeight))
                {
                    _items[_currentItems] = item;
                    _currentItems++;
                    _currentWeight += item.Weight;
                    _currentVolume += item.Volume;
                }
                

            }
            public bool EnsureQuantity(double currentQuantity, double incomingQuantity, double maxQuantity)
            {
                if (currentQuantity+incomingQuantity>maxQuantity)
                {
                return false;
                }
                else 
                return true;
            }
            public void DisplayStatusMessage()
            {
                DisplayError();
                ColorWriteDescriptionAlignment("ITEMS: ", _currentItems + "/" + _maxNumberOftems, Blue);
                ColorWriteDescriptionAlignment("WEIGH: ", _currentWeight + "/" + _maxWeight, Yellow);
                ColorWriteDescriptionAlignment("VOLUME: ", _currentVolume + "/" + _maxVolume, Green);
                WriteLine(" ");
                WriteLine(" ");
                
            }

            private void DisplayError()
            {
                if (IsFullOfItems())
                {
                    ColorWriteLine("The pack is full of items!. YOU CANNOT ADD MORE!", Red);
                }
                else if (IsFullOfWeight())
                {

                    ColorWriteLine("The pack is full of weight!", Red);
                }
                else if (IsFullOfVolume())
                {

                    ColorWriteLine("The pack is full of weight!", Red);
                }
            }


            public bool IsFullOfItems()
            {

                return _currentItems >= _maxNumberOftems;

            }
            public bool IsFullOfWeight()
            {
                return _currentWeight >= _maxWeight;
            }
            public bool IsFullOfVolume()
            {
                return _currentWeight >= _maxWeight;
            }

        }
    }
}