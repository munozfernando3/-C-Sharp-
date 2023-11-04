namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Party
    {
        public List<Character> Characters { get; }
        public IPlayer Player{get;}
        public string Name="Monsters";
        
        public Party(IPlayer player, List<Character> characters)
        {
            Player=player;
            Characters=characters;
        }
          public Party(IPlayer player, List<Character> characters, string name)
        {
            Player=player;
            Characters=characters;
            Name=name;
        }
     
    }
}