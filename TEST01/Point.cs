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
        private const int Mask = 0xFF;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Tile = Tile.Empty;
            Distance = 0;
        }

        public static implicit operator Point(int value)
        {
            int x = (value >> 8) & Mask;
            int y = value & Mask;
            
            return new Point(x, y);
        }

        public int X { get;  }
        public int Y { get;  }
        public Tile Tile { get; set; }
        /// <summary>
        /// 특정 점으로부터의 거리
        /// </summary>
        public int Distance { get; set; }

        public int Value => (X << 8) | Y;


        public static Point Invlid = new Point(-1, -1);

        public Point GetNeighbor(Direction direction)
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

        #region neighbors
        public Point Up
        {
            get
            {
                if (Y == Map.MaxY - 1)
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
                if (X == Map.MaxX - 1)
                    return Invlid;
                else
                    return new Point(X + 1, Y);
            }
        }
        #endregion

        #region equals
        public override bool Equals(object obj)
        {
            Point other = (Point) obj;
            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
        
        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
        #endregion

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}