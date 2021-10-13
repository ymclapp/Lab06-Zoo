using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Lab06Console;

namespace Lab06Console.Tests
{
  public class ProgramTests
  {
    [Fact]
    public void can_add_a_new_metal()
    {

      //Arrange
       Scorpions scorpions = new Scorpions();
      string members = "Klaus Meine, Rudolf Schenker, Michael Schenker";


      //Act
      string result = scorpions.PrintMembers();

      //Assert
      Assert.Equal(result, members);

    }

  }
}
