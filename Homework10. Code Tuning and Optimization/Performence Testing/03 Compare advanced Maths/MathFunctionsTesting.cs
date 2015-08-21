namespace _03_Compare_advanced_Maths
{
    internal class MathFunctionsTesting
    {
        internal static void Main()
        {
            MathFunctionsPerformence.PerformanceTest(Function.SquareRoot);
            MathFunctionsPerformence.PerformanceTest(Function.NaturalLogarithm);
            MathFunctionsPerformence.PerformanceTest(Function.Sinus);
        }
    }
}
