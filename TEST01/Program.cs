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
            WorldMap worldMap = new WorldMap();
            worldMap.GetWorldMap();

            AreaCalculator areaCalculator = new AreaCalculator();
            areaCalculator.GetMovablePoints();
        }
    }
}

