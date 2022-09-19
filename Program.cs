using System;
using System.Collections.Generic;
using Placement.Models;

namespace Placement
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the Queen's X coordinate (from 1-8)");
      int qXCord = Convert.ToInt32(Console.ReadLine());
      while (qXCord > 8 || qXCord < 1)
      {
        Console.WriteLine("Error: that number is not between 1 and 8, try again");
        qXCord = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("Enter the Queen's Y coordinate (from 1-8)");
      int qYCord = Convert.ToInt32(Console.ReadLine());
      while (qYCord > 8 || qYCord < 1)
      {
        Console.WriteLine("Error: that number is not between 1 and 8, try again");
        qYCord = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("Enter the other piece's X coordinate (from 1-8)");
      int pXCord = Convert.ToInt32(Console.ReadLine());
      while (pXCord > 8 || pXCord < 1)
      {
        Console.WriteLine("Error: that number is not between 1 and 8, try again");
        pXCord = Convert.ToInt32(Console.ReadLine());
      }
      Console.WriteLine("Enter the other piece's Y coordinate (from 1-8)");
      int pYCord = Convert.ToInt32(Console.ReadLine());
      while (pYCord > 8 || pYCord < 1)
      {
        Console.WriteLine("Error: that number is not between 1 and 8, try again");
        pYCord = Convert.ToInt32(Console.ReadLine());
      }
      Piece queen = new Piece(qXCord, qYCord);
      Piece otherPiece = new Piece(pXCord, pYCord);
      if (queen.XCord == otherPiece.XCord || queen.YCord == otherPiece.YCord)
      {
        Console.WriteLine("The queen will attack");
      }
      else if (Math.Abs(otherPiece.XCord - queen.XCord) == Math.Abs(otherPiece.YCord - queen.YCord))
      {
        Console.WriteLine("The queen will attack");
      }
      else
      {
        Console.WriteLine("The queen cannot attack the piece");
      }
    }
  }
}