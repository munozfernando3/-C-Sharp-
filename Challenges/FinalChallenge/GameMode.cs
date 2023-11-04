namespace MyApp // Note: actual namespace depends on the project name.
{
    public interface IGameMode
    {
        public void BattleSetUp();
        public Battle Battle { get; set; }
        public void Start();


    }
    public class PlayerVsComputerMode : IGameMode
    {
        public Battle Battle { get; set; }
        public void BattleSetUp()
        {
            var heroesParty = new Party(new StandardPlayer(), new List<Character>() { new TrueProgrammer(Facilities.User<string>.AskForValue("Heroe Name", Magenta)) });
            var zombieParty = new Party(new ComputerPlayer(), new List<Character>() { new Zombie(), new Skeleton() }, "FirstParty");
            var skeletonParty = new Party(new ComputerPlayer(), new List<Character>() { new Skeleton() }, "Skeleton Party");
            var FinalBossParty = new Party(new ComputerPlayer(), new List<Character>() { new TheUncodedOne() }, "FINAL BOSS Party");
            Battle = new Battle(heroesParty, zombieParty, skeletonParty, FinalBossParty);
        }
        public void Start()
        {
            BattleSetUp();
            Battle.Start();
        }
    }
}