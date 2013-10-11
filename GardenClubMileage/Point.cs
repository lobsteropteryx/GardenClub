using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenClubMileage
{
    public class Point
    {
        public Dictionary<PointNames, Neighbor> Neighbors;

        public Point()
        {
            Neighbors = new Dictionary<PointNames, Neighbor>();
        }
    }

    public class Neighbor
    {
        public Point Point {get; set;}
        public double Distance { get; set; }
    }
}
