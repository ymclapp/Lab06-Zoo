using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public class TheEagles : Rock//TheEagles is a child of Rock
  {
    public TheEagles() : base("The Eagles", "Glenn Frey, Don Henley, Bernie Leadon, Randy Meisner")//call  base constructor with name
    {
    }
    public override bool DeadMembers => true;

    public static string Instrument()
    {
      return ("Banjo, Mandolin, Dobro");
    }
    public override string Songs()
    {
      return("Hotel California, Desperado, New York Minute");
    }

    public override string PrintMembers()
    {
      Console.WriteLine("The members of the band are: ");
      return ("Don Henley, Timothy B. Schmidt, Joe Walsh, Deacon Frey, Vince Gill");
    }
  }
}
