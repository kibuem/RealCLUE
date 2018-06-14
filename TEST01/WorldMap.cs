using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TEST01
{
    class WorldMap
    {
        private static int x = 11;
        private static int y = 11;

        public Point[,] Map = new Point[y, x];
        
        public void GetWorldMap()
        {
            int a = 0, b = 0;
            
            for (int Y = 0; Y < y; Y++)
            {
                for (int X = 0; X < x; X++)
                {
                    Point[] points = new Point[1];
                    Point point = new Point((-x / 2) + a, (y / 2) - b);
                    points[0] = point;

                    Map[Y, X] = points[0];
                    //Console.WriteLine(map[Y, X]);
                    if (a >= x - 1)
                    {
                        a = 0;
                    }
                    else
                    {
                        a += 1;
                    }
                }
                b += 1;
            }
        }
    }
}