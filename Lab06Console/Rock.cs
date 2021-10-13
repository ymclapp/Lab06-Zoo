using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public abstract class Rock : Zoo  //extends Zoo
  {

    public Rock(string name, string founders)
    {
      Name = name;
      Founders = founders;
    }

  }
}
