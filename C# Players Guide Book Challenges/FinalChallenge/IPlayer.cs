namespace MyApp // Note: actual namespace depends on the project name.
{
    public interface IPlayer
    {


        public IAction ChooseAction(Battle battle, Character character);
    }


    public class StandardPlayer : IPlayer
    {
        private Battle currentBattle;
        public IAction ChooseAction(Battle battle, Character character)
        {
            currentBattle = battle;
            var optionsMenu = new LinearMenu<IAttack>(DisplayInstructions, new Punch(), new Slap(), new DoNotAttack());
            optionsMenu.Display();
            var optionSelected = optionsMenu.GetValue();
            if (optionSelected.GetType() == typeof(DoNotAttack))
            {
                return new DoNothing();
            }
            return new Attack(optionSelected, battle.GetEnemyPartyFor(character).Characters[0]);
        }
        public void DisplayInstructions()
        {
            currentBattle.DisplayBattleStatus();
            currentBattle.CheckForDeathCharacters(currentBattle.Monsters[currentBattle.currentParty]);
            WriteLine("---------------------------------------------");
            ColorWriteLine(currentBattle.currentCharacter.Name + "'s Turn", currentBattle.currentCharacter.Color);
            ColorWriteLine("Select attack", DarkGray);
            WriteLine(" ");
        }
    }
    public class ComputerPlayer : IPlayer
    {
        public IAction ChooseAction(Battle battle, Character character)
        {
             Thread.Sleep(3000);
            return new Attack(character.AttackType, battle.GetEnemyPartyFor(character).Characters[0]);
        }
    }

}