namespace Problem01.Size
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Size
    {
        private double width, height;
        
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public static Size GetRotatedSize(
            Size sizeBeforeRotation, double angleOfRotation)
        {
            double sinusTimesWidth = Math.Abs(Math.Sin(angleOfRotation) * sizeBeforeRotation.Width);
            double cosinusTimesWidth = Math.Abs(Math.Cos(angleOfRotation) * sizeBeforeRotation.Width);
            double sinusTimesHeight = Math.Abs(Math.Sin(angleOfRotation) * sizeBeforeRotation.Height);
            double cosinusTimesHeigth = Math.Abs(Math.Cos(angleOfRotation) * sizeBeforeRotation.Height);

            double rotatedFigureWidth = cosinusTimesWidth + sinusTimesHeight;
            double rotatedFigureHeight = sinusTimesWidth + cosinusTimesHeigth;

            Size rotatedFigure = new Size(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;
        }
    }
}
