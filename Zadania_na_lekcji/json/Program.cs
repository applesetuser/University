using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using Models;

// dotnet add package NuGet.CommandLine --version 5.8.0
// dotnet add package Newtonsoft.Json --version 12.0.3

namespace JsonSample
{
  public class Hero
  {
    public string Name;
    public int Strength;
    public int Dexterity;
    public int Intelligence;

    public void Init(int strength = 5, int dexterity = 5, int intelligence = 5)
    {
      this.Strength = strength;
      this.Dexterity = dexterity;
      this.Intelligence = intelligence;
    }

    public int GetStrength() { return this.Strength; }
    public int GetDexterity() { return this.Dexterity; }
    public int GetIntelligence() { return this.Intelligence; }

    public Hero(string name, string myclass)
    {
      this.Name = name;
      switch(myclass)
      {
        case "warior": Init(8, 5, 2); break;
        case "assassin": Init(3, 8, 4); break;
        case "sorcerer": Init(4, 2, 9); break;
        default: Init(); break;
      }
    }
    public static Hero Load(string name) 
    {
        name heroJson = File.ReadAllText(name + ".json");
        //Hero hero = new Hero();
        
        //Console.WriteLine(heroJson.ToString());
        //hero.Strength = (int)heroJson["Strength"]
        return hero;
      }
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      Hero hero = new Hero("Edward Białykij", "sorcerer");
      
      Console.WriteLine(hero.Name + " Str:{0} Dex:{1} Int:{2}",
                        hero.GetStrength(),
                        hero.GetDexterity(),
                        hero.GetIntelligence()
                        );
    }
  }
}