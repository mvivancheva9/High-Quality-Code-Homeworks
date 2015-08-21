namespace Problem03.RefactorLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoopStatement
    {
        public static void Main(int[] array, int expectedValue)
        {
            bool isFound = false;

            for (int i = 0; i < 100; i++)
            {
                var currentValue = array[i];
                if (currentValue == expectedValue)
                {
                    isFound = true;
                }
                else
                {
                    Console.WriteLine(currentValue);
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
