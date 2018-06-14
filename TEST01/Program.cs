using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;

namespace TEST01
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Point> points = WorldMap.Instance.GetMovableArea(1, 1, 2);
            List<Point> points2 = WorldMap.Instance.GetMovableArea(2, 3, 2);
//            
//            WorldMap worldMap = new WorldMap();
//            worldMap.GetWorldMap();
//
//            AreaCalculator areaCalculator = new AreaCalculator();
//            areaCalculator.GetMovablePoints();
        }
    }
}

