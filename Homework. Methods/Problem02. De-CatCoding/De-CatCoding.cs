namespace DeCatCipher
{
    using System;
    using System.Numerics;
    using System.Text;

    class DeCatCoding
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputAsArray = input.Split(' ');

            var output = EstimateOutput(inputAsArray);
            Print(output);
        }

        private static string[] EstimateOutput(string[] inputAsArray)
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string[] output = new string[inputAsArray.Length];
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                string currentWord = inputAsArray[i];
                int[] currentSequenceNumbers = new int[currentWord.Length];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    currentSequenceNumbers[j] = Array.IndexOf(letters, currentWord[j]);
                }
                output[i] = Conversion(currentSequenceNumbers, letters);
            }

            return output;
        }

        private static string Conversion(int[] currentSequenceNumbers, char[] letters)
        {
            BigInteger decNum = 0;
            BigInteger power = 1;
            for (int i = currentSequenceNumbers.Length - 1; i >= 0; i--)
            {
                decNum += (ulong)(currentSequenceNumbers[i]) * power;
                power *= 21;
            }
            BigInteger remainder = 0;
            string result = string.Empty;

            while (decNum > 0)
            {
                remainder = decNum % 26;
                char currentLetter = letters[(int)(remainder)];
                result = currentLetter + result;
                decNum = decNum / 26;

            }
            return result;
        }

        private static void Print(string[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                if (i == output.Length - 1)
                {
                    Console.Write("{0}", output[i]);
                }
                else
                {
                    Console.Write("{0} ", output[i]);
                }
            }
            Console.WriteLine();
        }
    }
}