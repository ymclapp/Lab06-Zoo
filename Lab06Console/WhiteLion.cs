using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public class WhiteLion : Metal//WhiteLion is a child of Metal
  {
    public WhiteLion() : base("White Lion")//call  base constructor with name
    {
    }
    public override bool DeadMembers => false;
    public override string Songs()
    {
      return ("When the Children Cry, Wait, Little Fighter");
    }
    public override string PrintMembers()
    {
      Console.WriteLine("The members of the band are: ");
      return ("Mike Tramp, Greg D'Angelo, Vito Bratta, James LoMenzo");

    }

  }
}
