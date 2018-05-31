using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Board board = TileFinder.GetMovableTiles(new Point(3,5), Dice.Roll(), new Board(24, 24));
            board.ShowBoard();
        }
    }
}
