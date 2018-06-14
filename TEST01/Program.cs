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
            Map.Instance.Initialize(3,3);
            Map.Instance.BuildBlocksForTest();
            List<Point> points = Map.Instance.GetMovableArea(0x11, 1);
            Console.WriteLine(points.Count);
        }
    }
}

