using System;

namespace Defining_classes
{
    public static class DistanceBetween3DPoints
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = secondPoint.X - firstPoint.X;
            double deltaY = secondPoint.Y - firstPoint.Y;
            double deltaZ = secondPoint.Z - secondPoint.Z;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
