namespace MyApp // Note: actual namespace depends on the project name.
{
    public class PotionGame
    {

        public Menu menuOfIngredients;
        public Potion potion;

        public Ingredient Ingredient;

        public PotionGame()
        {
            potion = new Potion();
            menuOfIngredients = new Menu("Ingredients", potion.DisplayPotion, GetNameOfIngredients());
            menuOfIngredients.AddSpecificColorOption("RESET", Red);
            menuOfIngredients.AddSpecificColorOption("END POTION", DarkRed);
        }
        public void Display()
        {
            while (true)
            {
                menuOfIngredients.Display();
                Run();
                menuOfIngredients.EditStatus(potion.DisplayPotion);
                if (menuOfIngredients.SelectedOption(7))
                {
                    DisplayFinalPotion();
                    break;
                }
            }
        }
        public void DisplayFinalPotion()
        {
            Clear();
            WriteLine("Final Potion: " + Program.ConvertToToLogicalString(potion.typeOfPotion.ToString()));
        }

        public void DisplayInstructions()
        {
            Facilities.ColorWriteLine("Press Enter to add an ingredient to your potion.  Use ↑ and ↓ to move", DarkGray);
        }
        public string[] GetNameOfIngredients()
        {
            string[] ingredients = new string[Enum.GetNames(typeof(Ingredient)).Length];
            int x = 0;
            foreach (Ingredient ingredient in Enum.GetValues(typeof(Ingredient)))
            {
                ingredients[x] = Program.ConvertToToLogicalString(ingredient.ToString());
                x++;
            }
            return ingredients;
        }
        public TypeOfPotion AddIngredient(Ingredient ingredient)
        {
            return ingredient switch
            {
                Ingredient.Stardust when potion.typeOfPotion == TypeOfPotion.Water => TypeOfPotion.Elixir,
                Ingredient.SnakeVenom when potion.typeOfPotion == TypeOfPotion.Elixir => TypeOfPotion.PoisonPotion,
                Ingredient.DragonBreath when potion.typeOfPotion == TypeOfPotion.Elixir => TypeOfPotion.FlyingPotion,
                Ingredient.ShadowGlass when potion.typeOfPotion == TypeOfPotion.Elixir => TypeOfPotion.InvisibililyPotion,
                Ingredient.EyeshineGem when potion.typeOfPotion == TypeOfPotion.Elixir => TypeOfPotion.NightSightPotion,
                Ingredient.ShadowGlass when potion.typeOfPotion == TypeOfPotion.NightSightPotion => TypeOfPotion.CloudyBrew,
                Ingredient.EyeshineGem when potion.typeOfPotion == TypeOfPotion.InvisibililyPotion => TypeOfPotion.CloudyBrew,
                Ingredient.Stardust when potion.typeOfPotion == TypeOfPotion.CloudyBrew => TypeOfPotion.WraithPotion,
                _ => TypeOfPotion.RuinedPotion
            };
        }
        public void Run()
        {
            if (menuOfIngredients.SelectedOption(1))
                potion.typeOfPotion = AddIngredient(Ingredient.Stardust);
            else if (menuOfIngredients.SelectedOption(2))
                potion.typeOfPotion = AddIngredient(Ingredient.SnakeVenom);
            else if (menuOfIngredients.SelectedOption(3))
                potion.typeOfPotion = AddIngredient(Ingredient.DragonBreath);
            else if (menuOfIngredients.SelectedOption(4))
                potion.typeOfPotion = AddIngredient(Ingredient.ShadowGlass);
            else if (menuOfIngredients.SelectedOption(5))
                potion.typeOfPotion = AddIngredient(Ingredient.EyeshineGem);
            else if (menuOfIngredients.SelectedOption(6))
                potion = new Potion();

        }
    }

}
