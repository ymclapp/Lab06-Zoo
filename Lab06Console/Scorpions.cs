using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public class Scorpions : Metal//Scorpions is a child of Metal
  {
    public Scorpions() : base("Scorpions")//call  base constructor with name
    {
    }
    public override bool DeadMembers => false;
    public override string Songs()
    {
      return ("The Zoo, Winds of Change, Rock You Like A Hurricane");
    }
     public override string PrintMembers()
    {
      Console.WriteLine("The members of the band are: ");
      return ("Klaus Meine, Rudolf Schenker, Michael Schenker");

    }
    
  }
  }
