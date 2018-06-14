using System;
using System.Collections.Generic;
using System.Data;

namespace TEST01
{
    public class WorldMap
    {
        #region singleton
        private static WorldMap _instance;

        public static WorldMap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WorldMap();

                return _instance;
            }
        }

        private WorldMap()
        {
            MaxX = 10;
            MaxY = 15;
        }
        #endregion

        public void Initialize(int maxX = 10, int maxY = 15)
        {
            MaxX = maxX;
            MaxY = maxY;
            
            for (int i = 0; i < MaxX; i++)
            for (int j = 0; j < MaxY; j++)
                _points[i, j] = new Point(i, j);
        }

        public void BuildBlocksForTest()
        {
            _points[1, 0].Tile = Tile.Block;
        }

        public static int MaxX { get; private set; }
        public static int MaxY { get; private set; }

        private readonly Point[,] _points = new Point[MaxX, MaxY];

        public List<Point> GetMovableArea(int x, int y, int dice)
        {
            return GetMovableArea(new Point(x, y), dice);
        }

        public List<Point> GetMovableArea(Point point, int dice)
        {
            throw new Exception();
        }

        public void MoveToNext(Point point, List<Point> points, int remainingDice)
        {
            Direction[] directions = (Direction[]) Enum.GetValues(typeof(Direction));

            foreach (Direction direction in directions)
            {
//                if (point.Up != Point.Invlid && point.Up.Tile == Tile.Empty)
//                    points.Add(point.Up);

                if (point.HasEmptyNeighbor(direction) == false)
                    continue;
                
                if (points.Contains(point[direction]))
                    continue;

                points.Add(point[direction]);

                if (remainingDice > 0)
                    MoveToNext(point[direction], points, remainingDice - 1);
            }
        }
    }
}