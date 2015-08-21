namespace IncreasingAbsoluteDifference
{
    using System;

    class IncreasingSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] sequence = new string[n];

            for (int i = 0; i < n; i++)
            {
                sequence[i] = Console.ReadLine();
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                string currentLine = sequence[i];
                AbsoluteDifference(currentLine);
            }
        }

        private static void AbsoluteDifference(string currentLine)
        {
            string[] currentLineAsString = currentLine.Split(' ');
            int[] numbers = new int[currentLineAsString.Length];
            for (int i = 0; i < currentLineAsString.Length; i++)
            {
                numbers[i] = int.Parse(currentLineAsString[i]);
            }
            int[] absolute = new int[numbers.Length - 1];
            for (int i = 0; i < absolute.Length; i++)
            {
                absolute[i] = Math.Abs(numbers[i] - numbers[i + 1]);
            }
            IncreasingSequence(absolute);
        }

        private static void IncreasingSequence(int[] absolute)
        {
            bool isIncreasing = true;
            for (int i = 0; i < absolute.Length - 1; i++)
            {
                if (((absolute[i + 1] - absolute[i]) == 1) || ((absolute[i + 1] - absolute[i]) == 0))
                {
                    continue;
                }
                else
                {
                    isIncreasing = false;
                    throw new Exception("The sequence is not increasing");
                }
            }
            Console.WriteLine(isIncreasing);
        }
    }
}