using System;
using System.Collections.Generic;

namespace TEST01
{
    class Program
    {

        static void Main(string[] args)
        {
            Map.Instance.Initialize(3,3);
            Map.Instance.BuildBlocksForTest();
            List<Point> points = Map.Instance.GetMovableArea(0x11, 1);
            points.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(points.Count);
        }
    }
}

