using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab04
{
    class Polygon
    {
        List<Point> points;
        List<Edge> edges;
        List<EdgeIndexes> edges_ind;

        public enum Axis {X_axis, Y_axis};

        public Polygon()
        {
            points = new List<Point>();
            edges = new List<Edge>();
            edges_ind = new List<EdgeIndexes>();
        }

        public List<Point> Points { get { return points; } }
        public List<Edge> Edges { get { return edges; } }
        public List<EdgeIndexes> EdgesIndexes { get { return edges_ind; } }

        private Point ToPoint(int x, int y)
        {
            Point p = new Point();
            p.X = x;
            p.Y = y;
            return p;
        }

        public void AddPoint(int x, int y)
        {
            points.Add(ToPoint(x,y));
        }

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public void DeletePoint(Point p)
        {
            DeleteAllEdgesFromPoint(p);
            points.Remove(p);
        }

        public void DeletePoint(int x, int y)
        {
            Point p = ToPoint(x, y);
            DeleteAllEdgesFromPoint(p);
            points.Remove(p);
        }

        public void DeletePoint(int index)
        {
            DeleteAllEdgesFromPoint(points[index]);
            points.RemoveAt(index);
        }

        // Индекс точки в списке точек
        private int IndexPoint(int x, int y)
        {
            return points.FindIndex((Point p) => { return p.X == x && p.Y == y; });
        }
        private int IndexPoint(Point p)
        {
            return IndexPoint(p.X, p.Y);
        }

        private void DeleteAllEdgesFromPoint(Point p)
        {
            int ind_point = IndexPoint(p.X,p.Y);
            int ind = edges_ind.FindIndex((EdgeIndexes e) => { return e.Ind_from == ind_point || e.Ind_to == ind_point; });
            while (ind != -1)
            {
                edges_ind.RemoveAt(ind);
                ind = edges_ind.FindIndex((EdgeIndexes e) => {return e.Ind_from == ind_point || e.Ind_to == ind_point;});
            }
            foreach (EdgeIndexes ei in edges_ind)
            {
                if (ei.Ind_from >= ind_point)
                    ei.DecreaseIndFrom();
                if (ei.Ind_to >= ind_point)
                    ei.DecreaseIndTo();
            }
        }

        public void DeleteEdge(Point from, Point to)
        {
            int i1 = IndexPoint(from);
            int i2 = IndexPoint(to);
            int ind = edges_ind.FindIndex((EdgeIndexes e) => { return e.Ind_from == i1 && e.Ind_to == i2; });
            if ( ind != -1)
                edges_ind.RemoveAt(ind);
        }

        public void DeleteEdge(int index)
        {
            edges_ind.RemoveAt(index);
        }

        public bool AddEdge(Point p_from, Point p_to)
        {
            if (edges.FindIndex((Edge e) =>
                {
                    Point p1 = e.P_from;
                    Point p2 = e.P_to;
                    return (p_from == p1 && p_to == p2) ||
                        (p_from == p2 && p_to == p1);
                }) != -1)
                return false;
            else
            {
                edges.Add(new Edge(p_from, p_to));
                return true;
            }
        }

        public bool AddEdgeIndexes(int ind_1, int ind_2)
        {
            EdgeIndexes edge = new EdgeIndexes(ind_1, ind_2);
            int ind = edges_ind.FindIndex((EdgeIndexes ei) => { return edge.Equals(ei); });
            if (ind != -1)
                return false;
            else
            {
                edges_ind.Add(edge);
                return true;
            }
        }

        public bool AddEdgeIndexes(Point p1, Point p2)
        {
            int ind1 = points.FindIndex((Point p) => { return p.Equals(p1); });
            int ind2 = points.FindIndex((Point p) => { return p.Equals(p2); });
            return AddEdgeIndexes(ind1, ind2);
        }

        public bool MovingPoint(Point p_old, Point p_new)
        {
            int ind = points.FindIndex((Point p)=>{ return p.X == p_old.X && p.Y == p_old.Y;});
            if (ind != -1)
            {
                points[ind] = p_new;
                return true;
            }
            return false;
        }

        public void RotateEdge(int ind)
        {
            
        }

        public Point FindIntersection(int ind1, int ind2)
        {
            return new Point();
        }

        private double degree_between_edges(int ind, int pointInd)
		{
            Point e1P1 = points[edges_ind[ind].Ind_from];
            Point e1P2 = points[edges_ind[ind].Ind_to];

            Point p = points[pointInd];

            int e1X = e1P1.X - p.X;
			int e1Y = e1P1.Y - p.Y;
			int e2X = e1P2.X - p.X;
			int e2Y = e1P2.Y - p.Y;
			double res = Math.Acos((e1X * e2X + e1Y * e2Y) / (Math.Sqrt(e1X * e1X + e1Y * e1Y) * Math.Sqrt(e2X * e2X + e2Y * e2Y))) * (180 / Math.PI);
			return res;
		}

        public bool pointInRect(int pointInd)
        {
            double sum_degrees = 0;
            for(int i = 0; i < edges_ind.Count; i++)
                sum_degrees += degree_between_edges(i, pointInd);
            if (sum_degrees == 360)
                return true;
            else
                return false;
        }

        public int getPointPosition(int pointInd, int edgeInd)
        {
            Point P1 = points[edges_ind[edgeInd].Ind_from];
            Point P2 = points[edges_ind[edgeInd].Ind_to];
            Point pt = points[pointInd];
            double z = (P2.Y - P1.Y) * pt.X + (P1.X - P2.X) * pt.Y + 
                        (P1.X * (P1.Y - P2.Y) + P1.Y * (P2.X - P1.X));
            if (z < 0)
                return -1;
            else
                if (z > 0)
                return 1;
            else
                return 0;
        }

        // Повернуть
        public void Rotate(double angle, int ind)
        {
            if (ind == -1) ind = 0;
            int x0 = points[ind].X;
            int y0 = points[ind].Y;
            angle *= (Math.PI / 180);
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            for (int i = 0; i < points.Count; ++i)
            {
                double x = points[i].X;
                double y = points[i].Y;

                double x1 = x0 + (x - x0) * cos - (y - y0) * sin;
                double y1 = y0 + (x - x0) * sin + (y - y0) * cos;

                points[i] = new Point((int)Math.Round(x1), (int)Math.Round(y1));
            }
        }

        // Перенести
        public void Translate(int by_x, int by_y)
        {
            for (int i = 0; i < points.Count; ++i)
            {
                points[i] = new Point(points[i].X + by_x, points[i].Y + by_y);
            }
        }

        // Отразить
        public void Reflect(Axis a)
        {
            int kx = 1, ky = 1;
            if(a == Axis.X_axis)
                ky = -1;
            if(a == Axis.Y_axis)
                kx = -1;

            for (int i = 0; i < points.Count; ++i)
            {
                Point p = new Point();
                p.X = points[i].X * kx;
                p.Y = points[i].Y * ky;
                points[i] = p;
            }
        }

        public Point getCenterPoint()
        {
            int cntX = 0;
            int cntY = 0;
            int sumX = 0;
            int sumY = 0;
            for (int i = 0; i < edges_ind.Count; ++i)
            {
                sumX += points[edges_ind[i].Ind_from].X;
                sumY += points[edges_ind[i].Ind_from].Y;
            }
            return new Point(sumX / edges_ind.Count, sumY / edges_ind.Count);
        }

        // Масштабировать
        public void Scale(double kx, double ky)
        {
            for (int i = 0; i < points.Count; ++i)
            {
                double x = points[i].X;
                double y = points[i].Y;

                Point center = getCenterPoint();
                x -= center.X;
                y -= center.Y;
                x *= kx;
                y *= ky;
                x += center.X;
                y += center.Y;

                points[i] = new Point((int)Math.Round(x), (int)Math.Round(y));
            }
        }

        public string[] PointsToString()
        {
            string[] strs = new string[points.Count];
            for (int i = 0; i < points.Count; ++i)
                strs[i] = "(" + points[i].X + "; " + points[i].Y + ")";
            return strs;
        }

        public string[] EdgesToString()
        {
            string[] strs = new string[edges_ind.Count];
            for (int i = 0; i < edges_ind.Count; ++i)
            {
                int ind1 = edges_ind[i].Ind_from;
                int ind2 = edges_ind[i].Ind_to;
                strs[i] = "(" + points[ind1].X + "; " + points[ind1].Y + ") - (" +
                    points[ind2].X + "; " + points[ind2].Y + ")";
            }
            return strs;
        }

    }

    class Edge
    {
        Point p_from, p_to;
        public Point P_from { get { return p_from; } }
        public Point P_to { get { return p_to; } }
        public Edge(Point p1, Point p2)
        {
            p_from = p1;
            p_to = p2;
        }

    }

    class EdgeIndexes
    {
        int ind_from, ind_to;
        public int Ind_from { get { return ind_from; } }
        public int Ind_to { get { return ind_to; } }
        public void DecreaseIndFrom()
        {
            --ind_from;
        }
        public void DecreaseIndTo()
        {
            --ind_to;
        }
        public EdgeIndexes(int p1, int p2)
        {
            ind_from = p1;
            ind_to = p2;
        }

        public bool Equals(EdgeIndexes ei)
        {
            return (ind_from == ei.ind_from && ind_to == ei.ind_to)
                || (ind_from == ei.ind_to && ind_to == ei.ind_from);
        }
    }
}
