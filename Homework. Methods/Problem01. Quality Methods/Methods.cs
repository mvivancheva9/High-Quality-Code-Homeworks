using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("The sides of the triange are not positive");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    return number + "is invalid number!";
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new Exception("Input array cannot be null or empty");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }
            return elements[0];
        }

        internal static void PrintPreciseNumber(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintPercentageNumber(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        internal static void PrintRightAlignedNumber(double number)
        {
            Console.WriteLine("{0,8}", number);
        }


        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }
        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintPreciseNumber(1.3);
            PrintPercentageNumber(0.75);
            PrintRightAlignedNumber(2.30);

            bool horizontal = IsLineHorizontal(-1, 2.5);
            bool vertical = IsLineVertical(3, 3);
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 3, 11), "Vidin, gamer, high results");
           
            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
