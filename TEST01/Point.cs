using System;
using Microsoft.Win32.SafeHandles;

namespace TEST01
{
    public enum Tile
    {
        Empty = 0,
        Block,
        Room
    }

    public enum Direction
    {
        Up,
        Down,
        Left, 
        Right
    }
    
    public struct Point 
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Tile = Tile.Empty;
        }

        public int X { get;  }
        public int Y { get;  }

        public int Value => X * 100 + Y;

        public Tile Tile { get; set; }

        public static Point Invlid = new Point(-1,-1);

        public override bool Equals(object obj)
        {
            Point other = (Point) obj;
            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public bool HasEmptyNeighbor(Direction direction)
        {
            Point neighbor = this[direction];

            if (neighbor.Equals(Invlid))
                return false;
            if (neighbor.Tile != Tile.Empty)
                return false;

            return true;
        }
        
        public Point this[Direction direction]
        {
            get
            {
                switch (direction)
                {
                    case Direction.Up:
                        return Up;
                    case Direction.Down:
                        return Down;
                    case Direction.Left:
                        return Left;
                    case Direction.Right:
                        return Right;
                    default:
                        throw new Exception();
                }        
            }
        }
        
        public Point Up
        {
            get
            {
                if (Y == WorldMap.MaxY - 1)
                    return Invlid;
                else
                    return new Point(X, Y + 1);
            }
        }

        public Point Down
        {
            get
            {
                if (Y == 0)
                    return Invlid;
                else
                    return new Point(X, Y - 1);
            }
        }

        public Point Left
        {
            get
            {
                if (X == 0)
                    return Invlid;
                else
                    return new Point(X - 1, Y);
            }
        }

        public Point Right
        {
            get
            {
                if (X == WorldMap.MaxX - 1)
                    return Invlid;
                else
                    return new Point(X + 1, Y);
            }
        }


        public override string ToString()
        {
            return $"좌표 : ({X}, {Y})";
        }
    }
}