using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public abstract class Character
    {
        public string? Name { get; set; }
        public IAttack AttackType { get; set; }
        public ConsoleColor Color{get;set;}
        private int _hp;
        public int HP
        {
            get => _hp;
            set => _hp = Math.Clamp(value, 0, MaxHP);
        }
        public int MaxHP { get; set; }

        public void SetUp(int maxLife)
        {
            MaxHP = maxLife;
            _hp = MaxHP;
        }
        public void BeAttacked(int damage)
        {
            _hp -= damage;
        }
        public bool IsAlive()
        {
            return _hp>0;
        }
    }
    public class Monster:Character
    {
        public Monster()
        {
            Color=DarkRed;
        }
       
        // public Weakness weakness
        // {
        //     get
        //     {
        //         if 
        //     }
        // }
    }
    public class Skeleton : Monster
    {
        public Skeleton()
        {
            Name = "Skeleton";
            AttackType = new BoneCrunch();
            SetUp(25);
        }
    }
     public class Zombie : Monster
    {
        public Zombie()
        {
            Name = "Zombie";
            AttackType = new ZombieBite();
            SetUp(15);
        }
    }
     public class Witch : Monster
    {
        public Witch()
        {
            Name = "Zombie";
            AttackType = new ZombieBite();
            SetUp(15);
        }
    }
    public class TheUncodedOne:Monster
    {
         public TheUncodedOne()
        {
            Name = "THE UNCODED ONE";
            AttackType = new UnRavelling();
            SetUp(15);
        }
    }
    public class TrueProgrammer : Character
    {

        public TrueProgrammer(string name)
        {
            Name = name;
            AttackType = new Punch();
            Color=ConsoleColor.Blue;
            SetUp(25);
        }

    }
    public enum Essence{Undying, Ethereal, }
public enum Weakness{}
}