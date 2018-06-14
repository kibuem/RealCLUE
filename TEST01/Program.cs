using System;
using System.Collections.Generic;

namespace TEST01
{
    class Program
    {

        static void Main(string[] args)
        {
            Map.Instance.Initialize();
            //            Map.Instance.InitializeForTest();

            //            List<Point> points = Map.Instance.GetMovableArea(0, 1);
            List<Point> points = Map.Instance.GetMovableArea(304, 5);
            points.ForEach(x => Console.WriteLine(x));

            DisplyMap();
        }

        static void DisplyMap()
        {
            for (int i = Map.MaxY - 1; i >= 0; i--)
            {
                for (int j = 0; j < Map.MaxX; j++)
                {
                    Console.Write(Map.Instance[j, i].Mark);
                    Console.Write(' ');
                }

                Console.WriteLine();
            }
        }
    }
}

