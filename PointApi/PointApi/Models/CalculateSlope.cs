namespace PointApi.Models
{
    public class CalculateSlope : ICalculateSlope
    {
        List<Point> points = new List<Point>();

        public CalculateSlope()
        {
            var point1 = new Point() { X = 2, Y = 3 };
            var point2 = new Point() { X = 4, Y = 1 };
            var point3 = new Point() { X = 6, Y = -1 };

            points.Add(point1);
            points.Add(point2);
            points.Add(point3);

        }

        public string IsEqualSlope()
        {
            int scope1 = (points[1].Y - points[0].Y) / (points[1].X - points[0].X);
            int scope2 = (points[2].Y - points[1].Y) / (points[2].X - points[1].X);

            if (scope1 == scope2) return "YES";
            else return "NO";


        }
    }

}

