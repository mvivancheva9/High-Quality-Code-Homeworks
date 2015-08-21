namespace _02_Compare_simple_Maths
{
    using System;
    using System.Diagnostics;

    public static class MathOperationPerformance
    {
        private static readonly Stopwatch StopWatch = new Stopwatch();
        private const int IntegerValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0f;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0M;
        private const int OperationCount = 100000;

        static MathOperationPerformance()
        {
            Console.WriteLine("Test math operations with all number variables set at value 1.");
        }

        public static void PerformanceTest(Opeartion operation)
        {
            Console.WriteLine("******" + operation + "******");

            int resultInt = IntegerValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultInt += IntegerValue;
                        break;
                    case Opeartion.Subtracion:
                        resultInt -= IntegerValue;
                        break;
                    case Opeartion.Multiplication:
                        resultInt *= IntegerValue;
                        break;
                    case Opeartion.Division:
                        resultInt /= IntegerValue;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not define");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Int", StopWatch.Elapsed);
            StopWatch.Reset();

            long resultLong = LongValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultLong += LongValue;
                        break;
                    case Opeartion.Subtracion:
                        resultLong -= LongValue;
                        break;
                    case Opeartion.Multiplication:
                        resultLong *= LongValue;
                        break;
                    case Opeartion.Division:
                        resultLong /= LongValue;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not define");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Long", StopWatch.Elapsed);
            StopWatch.Reset();

            float resultFloat = FloatValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultFloat += FloatValue;
                        break;
                    case Opeartion.Subtracion:
                        resultFloat -= FloatValue;
                        break;
                    case Opeartion.Multiplication:
                        resultFloat *= FloatValue;
                        break;
                    case Opeartion.Division:
                        resultFloat /= FloatValue;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not define");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Float", StopWatch.Elapsed);
            StopWatch.Reset();

            double resultDouble = DoubleValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultDouble += DoubleValue;
                        break;
                    case Opeartion.Subtracion:
                        resultDouble -= DoubleValue;
                        break;
                    case Opeartion.Multiplication:
                        resultDouble *= DoubleValue;
                        break;
                    case Opeartion.Division:
                        resultDouble /= DoubleValue;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not define");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Double", StopWatch.Elapsed);
            StopWatch.Reset();

            decimal resultDecimle = DecimalValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Opeartion.Addition:
                        resultDecimle += DecimalValue;
                        break;
                    case Opeartion.Subtracion:
                        resultDecimle -= DecimalValue;
                        break;
                    case Opeartion.Multiplication:
                        resultDecimle *= DecimalValue;
                        break;
                    case Opeartion.Division:
                        resultDecimle /= DecimalValue;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not define");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-30}:{1}", "Decimle", StopWatch.Elapsed);
            StopWatch.Reset();
        }
    }
}
