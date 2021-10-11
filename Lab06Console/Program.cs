using System;

namespace Lab06Console
{
    class Program
    {
        static void Main()
        {
        //Console.WriteLine("This is the ZOO!");
        Scorpions scorps = new Scorpions();
        scorps.HairStyle = "Pineapple";
        scorps.MemberCount = 5;
        scorps.CountryofOrigin = "Germany";
        Console.WriteLine("This is the ZOO!");
      Metal[] metals = new Metal[]
      {
        scorps,
      };
      for (int i = 0; i < metals.Length; i++)
      {
        Metal metal = metals[i];
        Console.WriteLine($"The band name is:  {metal.Name}");
        Console.WriteLine("MemberCount: {0}", metal.MemberCount);
        //Console.WriteLine(GetSongs);
        string[] songs = metal.GetSongs();
        metal.PrintMembers();
        metal.PrintSummary();
      }
        }

    }
  abstract class Zoo
  {
    public string Name { get; protected set; }  //can only assign in child class
    public string HairStyle { get; set; }
    public int MemberCount { get; set; }
    public string CountryofOrigin { get; set; }
    public abstract bool DeadMembers { get; }
    public abstract void PrintMembers();
    public void PrintSummary()
    {
      //Console.WriteLine($"{0}", Name);
      Console.WriteLine($"Has {MemberCount} members");
      //Console.WriteLine(GetSongs());
    }
  }
}
