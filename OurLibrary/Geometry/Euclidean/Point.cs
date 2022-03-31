using System;

namespace OurLibrary.Geometry.Euclidean
{
    /// <summary>
    /// Class defining a point in 3D euclidean space
    /// </summary>
    public class Point
    {
        /// <summary>
        /// First coordinate of the point.
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Second coordinate of the point.
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// Third coordinate of the point.
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// Initialises a new <see cref="Point"/> class.
        /// </summary>
        /// <param name="x"> First coordinate of the point. </param>
        /// <param name="y"> Second coordinate of the point. </param>
        /// <param name="z"> Third coordinate of the point. </param>
        public Point(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
    }
}
