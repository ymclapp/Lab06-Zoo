using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  class Scorpions : Metal
  {
    public Scorpions() : base("Scorpions")//call  base constructor with name
    {
    }
    public override bool DeadMembers => false;
    public override string[] GetSongs()
    {
      return new string[]
      {
        "The Zoo",
        "Winds of Change",
        "Rock You Like A Hurricane"
      };
    }
      public override void PrintMembers()
    {
      Console.WriteLine("The members of the band are:");
      Console.WriteLine("Klaus Meine");
      Console.WriteLine("Rudolf Schenker");
      Console.WriteLine("Michael Schenker");
    }
    
  }
  }
