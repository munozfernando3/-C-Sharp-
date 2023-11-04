using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Battle
    {
        Party Heroes { get; set; }
        Party FinalBoss { get; set; }
        public List<Party> Monsters { get; set; }
        public int currentParty = 0;

        public Character currentCharacter;
        Party TwoMonsters { get; set; }

        public Party GetEnemyPartyFor(Character character) => Heroes.Characters.Contains(character) ? Monsters[currentParty] : Heroes;
        public Party GetPartyFor(Character character) => Heroes.Characters.Contains(character) ? Heroes : Monsters[currentParty];

        // Party HeroesParty { get; set; }
        // Party MonsterParty { get; set; }
        public Battle(Party heroes, params Party[] monsters)
        {
            Heroes = heroes;
            Monsters = monsters.ToList();
        }
        public void Start()
        {
            Fight();
        }
        public void Fight()
        {
            bool endBattle = false;
            while (!endBattle)
            {
                DisplayBattleStatus();
                foreach (Party party in new[] { Heroes, Monsters[currentParty] })
                {
                    if (CheckForDeathParty(Monsters[currentParty]))
                    {
                        currentParty++;
                        if (currentParty == Monsters.Count)
                        {

                            Clear();
                            ColorWriteLine("THE HEROES HAS WON", Green);
                            endBattle = true;
                        }
                    }
                    if (Heroes.Characters.Count == 0)
                    {
                        Clear();
                        ColorWriteLine("THE UNCODED HAS WON", DarkRed);
                        endBattle = true;
                    }
                    foreach (Character character in party.Characters)
                    {
                        currentCharacter = character;
                        CheckForDeathCharacters(Monsters[currentParty]);
                        Thread.Sleep(2000);
                        WriteLine("-------------------------------------------------------------------------");
                        ColorWriteLine(character.Name + "'s Turn", character.Color);
                        var action = party.Player.ChooseAction(this, character);
                        action.Run(character, this);
                        WriteLine("--------------------------------------------------------------------------");
                    }
                }
            }

        }
        public void DisplayBattleStatus()
        {
            ColorWriteLine("===================================BATTLE=================================", DarkGray);
            foreach (Character character in Heroes.Characters)
            {
                ColorWrite(character.Name+": ",Blue);
                WriteLine($"{"("+character.HP+"/"+character.MaxHP+")", -20}");
            }
            ColorWriteLine("=====================================VS===================================", DarkGray);
            foreach (Character character in Monsters[currentParty].Characters)
            {
                ColorWrite($"{character.Name+": ", -10}", DarkRed);
                  WriteLine("("+character.HP+"/"+character.MaxHP+")");
            }
            ColorWriteLine("==========================================================================", DarkGray);
            WriteLine(" ");

        }
        public void CheckForDeathCharacters(Party Monsters)
        {
            foreach (Party party in new[] { Heroes, Monsters })
            {
                foreach (Character character in party.Characters)
                {
                    if (character.HP == 0)
                    {
                        Facilities.ColorWriteLine(character.Name + " has been defeated", Yellow);
                        party.Characters.Remove(character);
                    }
                }
            }
        }
        public bool CheckForDeathParty(Party party)
        {
            if (party.Characters.Count == 0)
            {
                Facilities.ColorWriteLine(party.Name + " has been defeated", Red);
                return true;
            }
            else
            {
                return false;
            }
        }



    }

    public enum PlayerType { Computer, PLayer }
}