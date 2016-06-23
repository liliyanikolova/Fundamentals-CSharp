using System;

namespace CohesionAndCoupling
{
    static class Shape
    {
                public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalculateVolume(this double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }

        public static double CalculateDiagonalXYZ(double width, double height, double depth)
        {
            double x1 = 0;
            double y1 = 0;
            double z1 = 0;
            double x2 = width;
            double y2 = height;
            double z2 = depth;
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalculateDiagonalXY(double width, double height)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = width;
            double y2 = height;
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDiagonalXZ(double width, double depth)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = width;
            double y2 = depth;
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDiagonalYZ(double height, double depth)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = height;
            double y2 = depth;
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
    }
}
