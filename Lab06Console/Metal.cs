using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public abstract class Metal : Zoo  //extends Zoo
  {
   // Metal metal = new Metal();
    public Metal(string name)
    {
      Name = name;
    }

    //public abstract string[] GetSongs();
  }
}
