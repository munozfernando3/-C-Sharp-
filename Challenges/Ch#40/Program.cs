using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            PotionGame potionGame=new PotionGame();
            potionGame.Display();

        }
       public static string ConvertToToLogicalString(string word)
        {

            string result = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]) && i != 0)
                {
                    result += ' ';
                }

                result += word[i];
            }
            return result;
        }
    }
    public enum Ingredient { Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem, }
    public enum TypeOfPotion { Water, Elixir, PoisonPotion, RuinedPotion, FlyingPotion, InvisibililyPotion,NightSightPotion, CloudyBrew, WraithPotion}
}