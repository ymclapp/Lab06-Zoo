using System;

namespace Lab06Console
{
    public class Program
    {
        static void Main(string[] args)
        {
      Console.WriteLine("This is the ZOO!");
        Metal scorps = new Scorpions();
        scorps.HairStyle = "Medium length and curly";
        scorps.MemberCount = 5;
        scorps.CountryofOrigin = "Germany";
      Metal lion = new WhiteLion();
      lion.HairStyle = "Long and wavy";
      lion.MemberCount = 4;
      lion.CountryofOrigin = "New York";
      Zoo[] metals = new Zoo[]
      {
        scorps,
        lion,
      };
      for (int i = 0; i < metals.Length; i++)
      {
        Zoo metal = metals[i];
        Console.WriteLine($"The band name is:  {metal.Name}");
        Console.WriteLine("MemberCount: {0}", metal.MemberCount);
        metal.PrintMembers();
        metal.PrintSummary();
        Console.WriteLine("*************************************************************************");
      }
        }


  }
  public abstract class Zoo
  {
    public string Name { get; protected set; }  //can only assign in child class
    public string HairStyle { get; set; }
    public int MemberCount { get; set; }
    public string CountryofOrigin { get; set; }
    public abstract bool DeadMembers { get; }
    public abstract string PrintMembers();
    public abstract string Songs();
    public void PrintSummary()
    {
      Console.WriteLine($"{Name}'s country of origin is " + CountryofOrigin);
      Console.WriteLine($"The primary hair style for the band is " + HairStyle);
      Console.WriteLine($"These are some of {Name}'s song: " + Songs());
    }
  }
}
