#region
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace TEST01
{
    public class Map
    {
        #region singleton
        private static Map _instance;

        public static Map Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Map();

                return _instance;
            }
        }

        private Map()
        {
        }
        #endregion

        public void Initialize(int maxX = 10, int maxY = 15)
        {
            MaxX = maxX;
            MaxY = maxY;

            _points = new Point[MaxX, MaxY];
            
            for (int i = 0; i < MaxX; i++)
            for (int j = 0; j < MaxY; j++)
                _points[i, j] = new Point(i, j);
        }

        public void BuildBlocksForTest()
        {
            _points[0, 2].Tile = Tile.Room;
            _points[1, 0].Tile = Tile.Block;
        }

        public static int MaxX { get; private set; }
        public static int MaxY { get; private set; }

        private Point[,] _points;

        public List<Point> GetMovableArea(int x, int y, int dice)
        {
            return GetMovableArea(new Point(x, y), dice);
        }

        public List<Point> GetMovableArea(Point point, int distance)
        {
            HashSet<Point> points = new HashSet<Point>();

            MoveToNext(point, points, distance);

            var pointsOfPlayers = PlayerManagerMock.Instance.PointsOfPlayrs;

            return points
                .Except(pointsOfPlayers)
                .Where(x => x.Distance == distance || x.Tile == Tile.Room)
                .OrderBy(x => x.Value)
                .ToList();
        }

        public void MoveToNext(Point point, HashSet<Point> points, int distance)
        {
            Direction[] directions = (Direction[]) Enum.GetValues(typeof(Direction));

            foreach (Direction direction in directions)
            {
                Point neighbor = point.GetNeighbor(direction);

                if (neighbor == Point.Invlid)
                    continue;

                if (neighbor.Tile != Tile.Empty)
                    continue;

                if (points.Contains(neighbor))
                    continue;

                neighbor.Distance = distance;
                points.Add(neighbor);

                if (distance > 0)
                    MoveToNext(neighbor, points, distance - 1);
            }
        }
    }
}