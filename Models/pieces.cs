using System;

namespace Placement.Models {
  public class Piece
  {
    public int XCord { get; set; }
    public int YCord { get; set; }

    public Piece(int xCord, int yCord)
    {
      XCord = xCord;
      YCord = yCord;
    }
    public int GetXCord()
    {
      return XCord;
    }
    public int GetYCord()
    {
      return YCord;
    }
  }
}