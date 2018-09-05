using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess;

namespace Chess.Test
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void CanAttackHorizontal_True()
    {
      QueenAttack testQueen = new QueenAttack();
      Assert.IsTrue(testQueen.CanAttackHorizontal(10, 3));
    }

    [TestMethod]
    public void CanAttackVertical_True()
    {
      QueenAttack testQueen = new QueenAttack();
      Assert.IsTrue(testQueen.CanAttackVertical(3, 8));
    }

    [TestMethod]
    public void CanAttackDiagonal_True()
    {
      QueenAttack testQueen = new QueenAttack();
      Assert.IsTrue(testQueen.CanAttackDiagonal(1, 5));
    }
  }
}
