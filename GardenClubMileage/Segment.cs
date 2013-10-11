using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GardenClubMileage
{
    public class Segment
    {
        //public Point A { get; set; }
        //public Point B {get; set;}
        private List<Point> vertices;
        public ReadOnlyCollection<Point> Vertices
        {
            get { return vertices.AsReadOnly(); }
        }
        public double Length { get; set; }

        public Segment()
        {
            vertices = new List<Point>(2);
        }

        public Segment(Point a, Point b, double length)
        {
            this.vertices = new List<Point>{a, b};

            //this.A = a;
            //this.B = b;
            this.Length = length;
        }
    }
}
