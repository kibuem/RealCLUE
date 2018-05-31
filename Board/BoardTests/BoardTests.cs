using Microsoft.VisualStudio.TestTools.UnitTesting;
using Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Tests
{
    [TestClass()]
    public class BoardTests
    {
        [TestMethod()]
        public void BoardTest()
        {
            Board board = new Board(24, 24);

            board.ShowBoard();
        }

        [TestMethod()]
        public void GetMovableTilesTest()
        {
            List<Point> answerPoints = new List<Point>
            {
                new Point(0, 3), new Point(1, 2), new Point(1, 4), new Point(2, 1),
                new Point(2, 3), new Point(2, 5), new Point(3, 0), new Point(3, 2),
                new Point(3, 4), new Point(3, 6), new Point(4, 1), new Point(4, 3),
                new Point(4, 5), new Point(5, 2), new Point(5, 4), new Point(6, 3)
            };
          
            Board board = TileFinder.GetMovableTiles(new Point(3, 3), 3, new Board(7, 7));

            List<Point> movablePoints = new List<Point>();

            for(int x = 0; x < board.Points.GetLength(0); x++)
            {
                for(int y = 0; y < board.Points.GetLength(1); y++)
                {
                    if(board.Points[x,y].isMovable)
                    {
                        movablePoints.Add(board.Points[x, y]);
                    }
                }
            }

            //Assert.AreEqual(movablePoints.Count, answerPoints.Count);

            for (int i = 0; i < movablePoints.Count; i++)
            {
                Assert.IsTrue(movablePoints[i].Equal(answerPoints[i]));
            }
        }
    }
}