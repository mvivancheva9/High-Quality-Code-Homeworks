using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(Utils.GetFileExtension("example"));
            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Distance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Distance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Paralelepiped.Width = 3;
            Paralelepiped.Height = 4;
            Paralelepiped.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Paralelepiped.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Paralelepiped.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Paralelepiped.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Paralelepiped.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Paralelepiped.CalcDiagonalYZ());
        }
    }
}
