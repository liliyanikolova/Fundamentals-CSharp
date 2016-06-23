using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Shape.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Shape.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Shape.Width = 3;
            Shape.Height = 4;
            Shape.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Utils.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Shape.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Shape.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Shape.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Shape.CalcDiagonalYZ());
        }
    }
}
