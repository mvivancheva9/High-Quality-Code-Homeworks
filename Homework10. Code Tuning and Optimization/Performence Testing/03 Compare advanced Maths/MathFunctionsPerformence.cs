namespace _03_Compare_advanced_Maths
{
    using System;
    using System.Diagnostics;

    public class MathFunctionsPerformence
    {
        private static readonly Stopwatch StopWatch = new Stopwatch();
        private const float FloatValue = 1000.0f;
        private const double DoubleValue = 1000.0;
        private const decimal DecimalValue = 1000.0M;
        private const int OperationCount = 100000;

        static MathFunctionsPerformence()
        {
            Console.WriteLine("Test math functions with float, double, decimal set at value 1000.");
        }

        public static void PerformanceTest(Function function)
        {
            Console.WriteLine("******" + function + "******");

            float resultFloat = FloatValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultFloat = (float)Math.Sqrt(FloatValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultFloat = (float)Math.Log(FloatValue);
                        break;
                    case Function.Sinus:
                        resultFloat = (float)Math.Sin(FloatValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Float", StopWatch.Elapsed);
            StopWatch.Reset();

            double resultDouble = DoubleValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDouble = (double)Math.Sqrt(DoubleValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDouble = (double)Math.Log(DoubleValue);
                        break;
                    case Function.Sinus:
                        resultDouble = (double)Math.Sin(DoubleValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Double", StopWatch.Elapsed);
            StopWatch.Reset();

            decimal resultDecimle = DecimalValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (function)
                {
                    case Function.SquareRoot:
                        resultDecimle = (decimal)Math.Sqrt((double)DecimalValue);
                        break;
                    case Function.NaturalLogarithm:
                        resultDecimle = (decimal)Math.Log((double)DecimalValue);
                        break;
                    case Function.Sinus:
                        resultDecimle = (decimal)Math.Sin((double)DecimalValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Decimle", StopWatch.Elapsed);
            StopWatch.Reset();
        }
    }
}
