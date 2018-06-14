using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TEST01;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Init()
        {
            WorldMap.Instance.Initialize(3,3);
            WorldMap.Instance.BuildBlocksForTest();
        }
        
        [Test]
        public void MoveToNextTest1()
        {
            List<Point> points = new List<Point>();
            WorldMap.Instance.MoveToNext(new Point(0, 0), points, 1);
            
            Assert.AreEqual(1, points.Count);
            
            Assert.AreEqual(1, points[0].Value);
        }
        
        [Test]
        public void MoveToNextTest2()
        {
            List<Point> points = new List<Point>();
            WorldMap.Instance.MoveToNext(new Point(0, 0), points, 2);
            
            Assert.AreEqual(1, points.Count);
            
            Assert.AreEqual(1, points[0].Value);
        }
        
        [Test]
        public void 장애물이없는경우()
        {
            List<Point> points = WorldMap.Instance.GetMovableArea(1, 1, 2);

            Assert.AreEqual(3, points.Count);
            
            Assert.AreEqual(103, points[0].Value);
            Assert.AreEqual(202, points[1].Value);
            Assert.AreEqual(301, points[2].Value);
        }
        
        [Test]
        public void 장애물이있는경우()
        {
//            WorldMap.Instance.SetBlock(2, 1);
            
            List<Point> points = WorldMap.Instance.GetMovableArea(1, 1, 2);

            Assert.AreEqual(2, points.Count);
            
            Assert.AreEqual(103, points[0].Value);
            Assert.AreEqual(202, points[1].Value);
        }
    }
}