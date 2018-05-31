using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    public class TileFinder
    {
        public static Board GetMovableTiles(Point HorsePos, int dice, Board board)
        {
            List<int> boundaries = new List<int>();
            int boardGrid = board.Points.GetLength(0);
            boundaries = GetCoordinateValue(dice);

            //board.Points[HorsePos.X, HorsePos.Y].isMovable = "H";

            foreach (int boundary in boundaries)
            {
                Console.WriteLine(boundary);

                for (int x = 0; x <= boundary; x++)
                {
                    int y = boundary - x;

                    if (Enumerable.Range(0, boardGrid).Contains(HorsePos.X + x) && Enumerable.Range(0, boardGrid).Contains(HorsePos.Y + y))
                        board.Points[HorsePos.X + x, HorsePos.Y + y].isMovable = true;

                    if (Enumerable.Range(0, boardGrid).Contains(HorsePos.X - x) && Enumerable.Range(0, boardGrid).Contains(HorsePos.Y + y))
                        board.Points[HorsePos.X - x, HorsePos.Y + y].isMovable = true;

                    if (Enumerable.Range(0, boardGrid).Contains(HorsePos.X + x) && Enumerable.Range(0, boardGrid).Contains(HorsePos.Y - y))
                        board.Points[HorsePos.X + x, HorsePos.Y - y].isMovable = true;

                    if (Enumerable.Range(0, boardGrid).Contains(HorsePos.X - x) && Enumerable.Range(0, boardGrid).Contains(HorsePos.Y - y))
                        board.Points[HorsePos.X - x, HorsePos.Y - y].isMovable = true;
                }
            }
            return board;
        }

        static List<int> GetCoordinateValue(int dice)
        {
            int value = dice;
            int coordValue;

            List<int> coordinateValues = new List<int>();

            for (int i = 0; i <= value; i++)
            {
                if (value - 2 * i > 0)
                {
                    coordValue = value - 2 * i;
                    coordinateValues.Add(coordValue);
                }
                else
                {
                    break;
                }
            }

            return coordinateValues;
        }

        public static Board RemoveDisableTiles(Point point, int dice, Board board)
        {
            throw new NotImplementedException();
        }
    }
}
