using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit;
using NUnit.Framework;
using GardenClubMileage;

namespace GardenClubTests
{
    [TestFixture]
    public class GardenClubTests
    {
        PathMapper map;
        private Point a;
        private Point b;
        private Segment s;

        [TestFixtureSetUp]
        public void init()
        {
            map = new PathMapper();
            a = new Point("a");
            b = new Point("b");
            s = new Segment(a, b, 1);
        }

        [Test]
        public void pointHasName()
        {
            Point p = new Point("test");
            Assert.IsTrue(p.Name == "test");
        }

        [Test]
        public void segmentHasTwoPoints()
        {
            Assert.IsTrue(s.Vertices.Count == 2);
        }

        [Test]
        public void segmentHasLength()
        {
            Assert.IsTrue(s.Length == 1);
        }

        [Test]
        public void ClubCarnationToMumsfordMatchesThreeSegments()
        {
            Segment cc_mum = map.Segments[1]; // Club Carnation --> Mumsford
            List<Segment> matches = map.GetNextSegments(cc_mum);
            Assert.AreEqual(3, matches.Count);
        }

        [Test]
        public void pathContainsAllVertices()
        {
            List<Segment> path = new List<Segment>(); //map.GetPath(map.Segments[1]);
            path.Add(map.Segments[0]);
            path.Add(map.Segments[1]);
            List<Point> points = path.SelectMany<Segment, Point>(x => x.Vertices).Distinct().ToList();
            Assert.IsTrue(points.Contains(map.Points[0]) && points.Contains(map.Points[1]) && points.Contains(map.Points[2]));
            Assert.IsTrue(points.Count == 3);
        }

        [Test]
        public void allSegmentsAreConnected()
        {
            foreach (Segment s in map.Segments)
            {
                foreach (Segment s2 in map.Segments)
                {
                    if (s != s2)
                    {
                        foreach (Point p2 in s2.Vertices)
                        {
                            foreach (Point p in s.Vertices)
                            {
                                if (p == p2)
                                {
                                    //A match!
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
