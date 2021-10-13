using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public class Beatles : Pop//child of Pop
  {
    public Beatles() : base("Beatles", true)//call the base constructor
    {
    }
    public override bool DeadMembers => true;
    public override string Songs()
    {
      return ("Hard Days Night, Yellow Submarine, Help");
    }
  }
}
