using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace RealClueFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            Map.Instance.Initialize();
            GameDirector.Instance.Run();

            List<Point> pointsToGo = new List<Point>();
            List<Point> roomPoints = new List<Point> { 306, 505, 606, 507 };
            foreach (var roomPoint in roomPoints)
            {
                List<Point> list = Map.Instance.GetMovableArea(roomPoint, 2);
                pointsToGo.AddRange(list);
            }

            List<Point> points = pointsToGo.Distinct().ToList();

            //List<Point> points = Map.Instance.GetMovableArea(102, 2);
            //            List<Point> points = Map.Instance.GetMovableArea(304, 3);
            //List<Point> points = Map.Instance.GetMovableArea(313, 5);
            //List<Point> points = Map.Instance.GetMovableArea(102, 5);
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
