using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GardenClubMileage
{
    public enum PointNames
    {
        ClubCarnation, DaringDaisies, Mumsford, RaptureRoses, AmazingAmaranthus, BerryNandina, Lillyville, GorgeousGeraniums, RiverWillows,
        KindlyHolly, ClubFlores, PleasantPetunias
    }

    public class PathMapper
    {

        public Dictionary<PointNames, Point> Points;

        public PathMapper()
        {
            //Nodes
            Points = new Dictionary<PointNames, Point>()
            {
                {PointNames.ClubCarnation, new Point()},
                {PointNames.Mumsford, new Point()},
                {PointNames.DaringDaisies, new Point()},
                {PointNames.RaptureRoses, new Point()},
                {PointNames.Lillyville, new Point()},
                {PointNames.GorgeousGeraniums, new Point()},
                {PointNames.KindlyHolly, new Point()},
                {PointNames.BerryNandina, new Point()},
                {PointNames.AmazingAmaranthus, new Point()},
                {PointNames.RiverWillows, new Point()},
                {PointNames.ClubFlores, new Point()},
                {PointNames.PleasantPetunias, new Point()}
            };

            //Neighbors
            Points[PointNames.ClubCarnation].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.ClubCarnation].Neighbors.Add(PointNames.DaringDaisies, new Neighbor { Point = Points[PointNames.DaringDaisies], Distance = 28.2 });
            Points[PointNames.ClubCarnation].Neighbors.Add(PointNames.Mumsford, new Neighbor { Point = Points[PointNames.Mumsford], Distance = 16.401 });

            Points[PointNames.DaringDaisies].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.DaringDaisies].Neighbors.Add(PointNames.ClubCarnation, new Neighbor { Point = Points[PointNames.ClubCarnation], Distance = 28.2 });
            Points[PointNames.DaringDaisies].Neighbors.Add(PointNames.RaptureRoses, new Neighbor { Point = Points[PointNames.RaptureRoses], Distance = 23.508 });
            Points[PointNames.DaringDaisies].Neighbors.Add(PointNames.Lillyville, new Neighbor { Point = Points[PointNames.Lillyville], Distance = 32.3 });
            Points[PointNames.DaringDaisies].Neighbors.Add(PointNames.Mumsford, new Neighbor { Point = Points[PointNames.Mumsford], Distance = 22.8 });

            Points[PointNames.Mumsford].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.Mumsford].Neighbors.Add(PointNames.ClubCarnation, new Neighbor { Point = Points[PointNames.ClubCarnation], Distance = 16.401 });
            Points[PointNames.Mumsford].Neighbors.Add(PointNames.AmazingAmaranthus, new Neighbor { Point = Points[PointNames.AmazingAmaranthus], Distance = 35.73 });

            Points[PointNames.RaptureRoses].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.RaptureRoses].Neighbors.Add(PointNames.DaringDaisies, new Neighbor { Point = Points[PointNames.ClubCarnation], Distance = 23.508 });
            Points[PointNames.RaptureRoses].Neighbors.Add(PointNames.GorgeousGeraniums, new Neighbor { Point = Points[PointNames.GorgeousGeraniums], Distance = 27.75 });

            Points[PointNames.GorgeousGeraniums].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.GorgeousGeraniums].Neighbors.Add(PointNames.RaptureRoses, new Neighbor { Point = Points[PointNames.RaptureRoses], Distance = 27.75 });
            Points[PointNames.GorgeousGeraniums].Neighbors.Add(PointNames.KindlyHolly, new Neighbor { Point = Points[PointNames.KindlyHolly], Distance = 33.305 });

            Points[PointNames.Lillyville].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.Lillyville].Neighbors.Add(PointNames.DaringDaisies, new Neighbor { Point = Points[PointNames.DaringDaisies], Distance = 32.3 });
            Points[PointNames.Lillyville].Neighbors.Add(PointNames.KindlyHolly, new Neighbor { Point = Points[PointNames.KindlyHolly], Distance = 28.9 });
            Points[PointNames.Lillyville].Neighbors.Add(PointNames.BerryNandina, new Neighbor { Point = Points[PointNames.BerryNandina], Distance = 18.01 });

            Points[PointNames.BerryNandina].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.BerryNandina].Neighbors.Add(PointNames.Lillyville, new Neighbor { Point = Points[PointNames.Lillyville], Distance = 18.01 });
            Points[PointNames.BerryNandina].Neighbors.Add(PointNames.AmazingAmaranthus, new Neighbor { Point = Points[PointNames.AmazingAmaranthus], Distance = 41.3 });
            Points[PointNames.BerryNandina].Neighbors.Add(PointNames.RiverWillows, new Neighbor { Point = Points[PointNames.RiverWillows], Distance = 17.2 });

            Points[PointNames.AmazingAmaranthus].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.AmazingAmaranthus].Neighbors.Add(PointNames.Mumsford, new Neighbor { Point = Points[PointNames.Mumsford], Distance = 35.73 });
            Points[PointNames.AmazingAmaranthus].Neighbors.Add(PointNames.BerryNandina, new Neighbor { Point = Points[PointNames.BerryNandina], Distance = 41.3 });
            Points[PointNames.AmazingAmaranthus].Neighbors.Add(PointNames.RiverWillows, new Neighbor { Point = Points[PointNames.RiverWillows], Distance = 46.535 });

            Points[PointNames.RiverWillows].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.RiverWillows].Neighbors.Add(PointNames.AmazingAmaranthus, new Neighbor { Point = Points[PointNames.AmazingAmaranthus], Distance = 46.535 });
            Points[PointNames.RiverWillows].Neighbors.Add(PointNames.BerryNandina, new Neighbor { Point = Points[PointNames.BerryNandina], Distance = 17.2 });
            Points[PointNames.RiverWillows].Neighbors.Add(PointNames.KindlyHolly, new Neighbor { Point = Points[PointNames.KindlyHolly], Distance = 29.92 });
            Points[PointNames.RiverWillows].Neighbors.Add(PointNames.PleasantPetunias, new Neighbor { Point = Points[PointNames.PleasantPetunias], Distance = 41.43 });

            Points[PointNames.KindlyHolly].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.KindlyHolly].Neighbors.Add(PointNames.GorgeousGeraniums, new Neighbor { Point = Points[PointNames.GorgeousGeraniums], Distance = 33.305 });
            Points[PointNames.KindlyHolly].Neighbors.Add(PointNames.RiverWillows, new Neighbor { Point = Points[PointNames.RiverWillows], Distance = 29.92 });
            Points[PointNames.KindlyHolly].Neighbors.Add(PointNames.Lillyville, new Neighbor { Point = Points[PointNames.Lillyville], Distance = 28.9 });
            Points[PointNames.KindlyHolly].Neighbors.Add(PointNames.ClubFlores, new Neighbor { Point = Points[PointNames.ClubFlores], Distance = 27.2 });

            Points[PointNames.ClubFlores].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.ClubFlores].Neighbors.Add(PointNames.KindlyHolly, new Neighbor { Point = Points[PointNames.KindlyHolly], Distance = 27.2 });
            Points[PointNames.ClubFlores].Neighbors.Add(PointNames.PleasantPetunias, new Neighbor { Point = Points[PointNames.PleasantPetunias], Distance = 24.618 });

            Points[PointNames.PleasantPetunias].Neighbors = new Dictionary<PointNames, Neighbor>();
            Points[PointNames.PleasantPetunias].Neighbors.Add(PointNames.ClubFlores, new Neighbor { Point = Points[PointNames.ClubFlores], Distance = 24.618 });
            Points[PointNames.PleasantPetunias].Neighbors.Add(PointNames.RiverWillows, new Neighbor { Point = Points[PointNames.RiverWillows], Distance = 41.43 });
        }

        public Dictionary<PointNames, double> Dijkstra()
        {
            Dictionary<PointNames, double> previous = new Dictionary<PointNames, double>();
            Dictionary<PointNames, double> dist = new Dictionary<PointNames, double>(Points.Count);

            foreach (KeyValuePair<PointNames, Point> p in Points)
            {
                dist[p.Key] = Double.MaxValue;
            }

            dist[PointNames.ClubCarnation] = 0;
            Dictionary<PointNames, Point> Q = new Dictionary<PointNames, Point>(Points);
            while (Q.Count != 0)
            {
                KeyValuePair<PointNames, Point> u = new KeyValuePair<PointNames, Point>(PointNames.ClubCarnation, Points[PointNames.ClubCarnation]);
                double d = Double.MaxValue;
                foreach (KeyValuePair<PointNames, Point> p in Q)
                {
                    if (dist[p.Key] < d)
                    {
                        u = p;
                    }
                }
                Q.Remove(u.Key);
                if (u.Key == PointNames.PleasantPetunias)
                {
                    previous.Add(u.Key, dist[u.Key]);
                    break;
                }

                if (dist[u.Key] == Double.MaxValue)
                {
                    break;
                }

                foreach (KeyValuePair<PointNames, Neighbor> v in Points[u.Key].Neighbors)
                {
                    if (Q.ContainsKey(v.Key))
                    {
                        double alt = dist[u.Key] + v.Value.Distance;
                        if (alt < dist[v.Key])
                        {
                            dist[v.Key] = alt;
                            if (!previous.ContainsKey(u.Key))
                            {
                                previous.Add(u.Key, dist[u.Key]);
                            }
                        }
                    }
                }
            }
            return previous;
        }
    }
}
