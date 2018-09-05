using System;

namespace Chess
{
  public class QueenAttack
  {
    public int xPos = 3;
    public int yPos = 3;

    public bool CanAttackHorizontal(int x, int y)
    {
      return (yPos == y) ? true : false;
    }

    public bool CanAttackVertical(int x, int y)
    {
      return (xPos == x) ? true : false;
    }

    public bool CanAttackDiagonal(int x, int y)
    {
      int xDifference = x - xPos;
      int yDifference = y - yPos;

      xDifference = Math.Abs(xDifference);
      yDifference = Math.Abs(yDifference);

      return (xDifference == yDifference) ? true : false;

    }
  }
}
