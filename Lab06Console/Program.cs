using System;

namespace Lab06Console
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("This is the ZOO!");
      Metal scorps = new Scorpions();
      scorps.HairStyle = "medium length and curly";
      scorps.MemberCount = 5;
      scorps.CountryofOrigin = "Germany";

      Metal lion = new WhiteLion();
      lion.HairStyle = "long and wavy";
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
        Console.WriteLine("Metal Genre");
        Console.WriteLine($"The band name is:  {metal.Name}");
        Console.WriteLine("Member Count: {0}", metal.MemberCount);
        Console.WriteLine($"Dead members = {metal.DeadMembers}");
        metal.PrintMembers();
        metal.PrintSummary();
        Console.WriteLine("*************************************************************************");
      }//end of the metal for loop
      //----------------------------------------End of Metal-----------------------------------------------------
      Rock eagles = new TheEagles();
      eagles.HairStyle = "medium length and curly";
      eagles.MemberCount = 6;
      eagles.CountryofOrigin = "California";
 
      Zoo[] rocks = new Zoo[]
      {
            eagles,
            //strayCats,
      };
      for (int i = 0; i < rocks.Length; i++)
      {
        Zoo rock = rocks[i];
        Console.WriteLine("Rock Genre");
        Console.WriteLine($"The band name is:  {rock.Name}");
        Console.WriteLine("Member Count: {0}", rock.MemberCount);
        Console.WriteLine($"{rock.Name} founding members are:  { rock.Founders}");
        Console.WriteLine($"Dead members = {rock.DeadMembers}");
        //Console.WriteLine($"{rock.Name} utilizes some unique instruments like {rock.Instrument}");
        rock.PrintMembers();
        rock.PrintSummary();
        Console.WriteLine("*************************************************************************");
      }//end of the for rock loop
      //-----------------------------------------------End of Rock---------------------------------------------------

      Pop beatles = new Beatles();
      beatles.HairStyle = "bowl cut";
      beatles.MemberCount = 4;
      beatles.CountryofOrigin = "UK";

      Zoo[] pops = new Zoo[]
      {
        beatles,
      };
      for(int i = 0; i < pops.Length; i++)
      {
        Zoo pop = pops[i];
        Console.WriteLine("Pop Genre");
        Console.WriteLine($"The band name is:  {pop.Name}");
        Console.WriteLine("Member Count: {0}", pop.MemberCount);
        Console.WriteLine($"{pop.Name} had a TV Show?  {pop.TVShow}");
      }

    }//end of Main
  }

  
  public abstract class Zoo
  {
    public string Name { get; protected set; }  //can only assign in child class
    public string Founders { get; protected set; }
    //public string Instrument { get; set; }  //needs to not inherit from Zoo
    public bool TVShow { get; }
    public string HairStyle { get; set; }
    public int MemberCount { get; set; }
    public string CountryofOrigin { get; set; }
    public abstract bool DeadMembers  { get; }
    public abstract string PrintMembers();
    public abstract string Songs();
    public void PrintSummary()
    {
      Console.WriteLine($"{Name}'s country of origin is " + CountryofOrigin);
      Console.WriteLine($"The primary hair style for the band is " + HairStyle);
      Console.WriteLine($"These are some of {Name}'s songs: " + Songs());
    }
    }
  }

