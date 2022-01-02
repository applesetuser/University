using System;
using System.IO;

namespace hero
{
    public class Hero
    {
    public string Name;
    static int Strength;
    static int Dexterity;
    static int Intelligence;
    static int HP;

    static void Init(int strength = 5, int dexterity = 5, int intelligence = 5, int healthpoints = 100)
    {
      Strength = strength;
      Dexterity = dexterity;
      Intelligence = intelligence;
      HP = healthpoints;
    }

    public int GetStrength() { return Strength; }
    public int GetDexterity() { return Dexterity; }
    public int GetIntelligence() { return Intelligence; }
    public int GetHP() { return HP; }

    public Hero(string name, string myclass)
      {
        Name = name;
        switch(myclass)
        {
          case "warior": Init(8, 5, 2, 200); break;
          case "assassin": Init(3, 8, 4, 100); break;
          case "sorcerer": Init(4, 2, 9, 100); break;
          default: Init(); break;
        }
      }
    }
      /*  public void LevelUp()
        {
        if (myclass == warior)
        {
            Console.WriteLine("You leveled up !");
            Console.WriteLine("Strenght +3");
            Console.WriteLine("Dexterity -1");
            Console.WriteLine("Intelligence +1");
            Console.WriteLine("HP +30"); 
        }
        else if (myclass == assassin)
        {
            Console.WriteLine("You leveled up !");
            Console.WriteLine("Strenght +3");
            Console.WriteLine("Dexterity +5");
            Console.WriteLine("Intelligence +1");
            Console.WriteLine("HP +10");
        }
        else if (myclass == sorcerer)
        {
            Console.WriteLine("You leveled up !");
            Console.WriteLine("Strenght +0");
            Console.WriteLine("Dexterity +5");
            Console.WriteLine("Intelligence +10");
            Console.WriteLine("HP +10");
        }
        }  
        */
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
      Hero hero = new Hero("Edward Białykij", "sorcerer");
      Console.WriteLine("Heros1: "+ hero.Name + " Str:{0} Dex:{1} Int:{2} HP:{3}", hero.GetStrength(), hero.GetDexterity(), hero.GetIntelligence(), hero.GetHP());
      Console.WriteLine();
      Hero hero2 = new Hero("Moczybroda", "warior");
      Console.WriteLine("Heros2: "+ hero2.Name + " Str:{0} Dex:{1} Int:{2} HP:{3}", hero2.GetStrength(), hero2.GetDexterity(), hero2.GetIntelligence(), hero2.GetHP());
      Console.WriteLine();

    }
  }
}

