using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenClubMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            PathMapper m = new PathMapper();
            Dictionary<PointNames, double> path = m.Dijkstra();

            foreach (KeyValuePair<PointNames, double> p in path)
            {
                Console.WriteLine(p.Key + " (" + p.Value + ")");
            }
            Console.ReadKey();
        }
    }
}
