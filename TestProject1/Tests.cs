#region
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TEST01;
#endregion

namespace TestProject1
{
    [TestClass]
    public class Tests
    {
        [TestInitialize]
        public void Init()
        {
//            Map.Instance.Initialize();
            Map.Instance.InitializeForTest();
        }

        [TestMethod]
        public void 원점에서_1칸_이동()
        {
            // R * * 
            // O * * 
            // S X * 

            List<Point> points = Map.Instance.GetMovableArea(0, 1);

            Assert.AreEqual(1, points.Count);
            Assert.IsTrue(points.Contains(1));
        }

        [TestMethod]
        public void 가운데에서_1칸_이동()
        {
            // R O * 
            // O S O 
            // * X * 

            List<Point> points = Map.Instance.GetMovableArea(101, 1);

            Assert.AreEqual(3, points.Count);
            Assert.IsTrue(points.Contains(1));
            Assert.IsTrue(points.Contains(102));
            Assert.IsTrue(points.Contains(201));
        }

        [TestMethod]
        public void 원점에서_2칸_이동()
        {
            // R * * 
            // * O * 
            // S X * 

            List<Point> points = Map.Instance.GetMovableArea(0, 2);

            Assert.AreEqual(2, points.Count);
            Assert.IsTrue(points.Contains(2));
            Assert.IsTrue(points.Contains(new Point(1,1)));
        }

        [TestMethod]
        public void 원점에서_3칸_이동()
        {
            // R O * 
            // * * O 
            // S X * 

            List<Point> points = Map.Instance.GetMovableArea(0, 3);

            Assert.AreEqual(3, points.Count);
            Assert.IsTrue(points.Contains(102));
            Assert.IsTrue(points.Contains(201));
            Assert.IsTrue(points.Contains(2), "방에는 거리에 상관없이 들어갈 수 있음");
        }
    }
}