namespace Problem02.PrintStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Print
    {
        public void PrintStatistics(double[] sequence)
        {
            this.FindMax(sequence);
            this.FindMin(sequence);
            this.FindAverage(sequence);
        }

        private void FindMax(double[] sequence)
        {
            var maxElement = sequence.Max();
            this.PrintMax(maxElement);
        }

        private void PrintMax(double maxElement)
        {
            Console.WriteLine(maxElement);
        }

        private void FindMin(double[] sequence)
        {
            var minElement = sequence.Min();
            this.PrintMax(minElement);
        }

        private void PrintMin(double minElement)
        {
            Console.WriteLine(minElement);
        }

        private void FindAverage(double[] sequence)
        {
            var average = sequence.Average();
            this.PrintMax(average);
        }

        private void PrintAverage(double average)
        {
            Console.WriteLine(average);
        }
    }
}
