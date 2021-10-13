using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06Console
{
  public abstract class Pop : Zoo  //extends Zoo
  {

    public Pop(string name, bool tvShow)
    {
      Name = name;
      TVShow = tvShow;
    }

  }
}
