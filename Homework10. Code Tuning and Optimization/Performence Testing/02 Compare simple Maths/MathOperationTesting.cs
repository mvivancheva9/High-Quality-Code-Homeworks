namespace _02_Compare_simple_Maths
{
    internal class MathOperationTesting
    {
        internal static void Main()
        {
            MathOperationPerformance.PerformanceTest(Opeartion.Addition);
            MathOperationPerformance.PerformanceTest(Opeartion.Subtracion);
            MathOperationPerformance.PerformanceTest(Opeartion.Multiplication);
            MathOperationPerformance.PerformanceTest(Opeartion.Division);
        }
    }
}
