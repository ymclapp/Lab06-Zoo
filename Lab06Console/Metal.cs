using System;

namespace Lab06Console
{
  abstract class Metal : Zoo  //extends Zoo
  {
    public Metal(string name)
    {
      Name = name;
    }

    public abstract string[] GetSongs();
  }
}
