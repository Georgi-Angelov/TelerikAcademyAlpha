using System;
using System.Globalization;
using System.Threading;
 
namespace Defining_classes
{
     
    class StartUp
    {
       
        static void Main(string[] args)
        {
            Version currentVersion = new Version(2, 0);
            Console.Write("Version {0} is ", currentVersion);
            //Point3D firstPoint = new Point3D(1, 4, 5);
            //Point3D secondPoint = new Point3D(12, 15, 5);

            //Console.WriteLine(DistanceBetween3DPoints.CalculateDistance(firstPoint,secondPoint));
            //Console.WriteLine(firstPoint.ToString());

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Path loadedPath = PathStorage.LoadPath(@"../../SamplePath.txt");
            for (int i = 0; i < loadedPath.PathList.Count; i++)
            {
                Console.WriteLine(loadedPath.PathList[i]);
            }
        }
    }
}
