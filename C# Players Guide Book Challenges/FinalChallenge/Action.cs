using System.Data;
using System.Reflection.PortableExecutable;

namespace MyApp
{

    public interface IAction
    {
        public void Run(Character character, Battle battle);
    }
    public class DoNothing : IAction
    {
        public DoNothing()
        {

        }
        public void Run(Character character, Battle battle)
        {
            WriteLine(character.Name + " did nothing");
        }


    }
    public class Attack : IAction
    {
        public IAttack AttackType { get; set; }
        public Character Target { get; }
        public Attack(IAttack attackType, Character character)
        {
            AttackType = attackType;
            Target = character;
        }
        public void Run(Character character, Battle battle)
        {
            int damage = character.AttackType.Damage;
            Target.HP -= damage;
            WriteLine(character.Name + " used " + AttackType.Name + " on " + Target.Name);
            Write(AttackType.Name + " dealt ");
            ColorWrite($"{damage}", ConsoleColor.Cyan);
            WriteLine(" to " + Target.Name);
            WriteLine(Target.Name + " is now at " + Target.HP + "/" + Target.MaxHP);
            if (!Target.IsAlive())
            {
                battle.GetPartyFor(Target).Characters.Remove(Target);
                ColorWriteLine($"{Target.Name} was defeated!", Yellow);
            }
        }
    }
    public interface IAttack
    {
        public string Name { get; }
        public int Damage { get; }
   
    
    }
    public class Punch : IAttack
    {
        public string Name { get => "PUNCH"; }
        public int Damage { get => 5; }
       
        
    }  
    public class DoNotAttack : IAttack
    {
        public string Name { get => "Do Nothing"; }
        public int Damage { get => 0; }
          
       
    
    }  
     public class Slap : IAttack
    {
        public string Name { get => "SLAP"; }
        public int Damage { get => 10; }
      

    }
    public class BoneCrunch : IAttack
    {
        public string Name { get => "BONE CRUNCH"; }
        public int Damage { get => GenerateRandomDamage(0, 2); }
        public int GenerateRandomDamage(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
          
         public override string ToString()=>Name;

    }
    public class ZombieBite : IAttack
    {
        public string Name { get => "ZOMBIE BITE"; }
        public int Damage { get => 3; }
 public override string ToString()=>Name;
    }
    public class UnRavelling : IAttack
    {
        public string Name { get => "UNRAVELLING"; }
        public int Damage { get => GenerateRandomDamage(0, 3); }
         public override string ToString()=>Name;
        public int GenerateRandomDamage(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }


}
