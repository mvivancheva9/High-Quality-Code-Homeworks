﻿using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new NullReferenceException("The array should not be null");
        }

        if (arr.Length == 0)
        {
            throw new ArgumentException("The array should not be empty");
        }

        if (startIndex < 0)
        {
            throw new ArgumentOutOfRangeException("The start Index should not be negative");
        }

        if (startIndex > arr.Length - 1)
        {
            throw new ArgumentOutOfRangeException("The start Index should not be bigger than the lenght of the array - 1");
        }

        if (count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("The count for the substring should not be bigger than the lenght of the array");
        }

        if (startIndex + count > arr.Length)
        {
            throw new ArgumentOutOfRangeException("The chosen substring is within invalid range");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("The count for extracting the ending should not be bigger than the lenght of the array");
        }

        if (count < 1)
        {
            throw new ArgumentOutOfRangeException("The count for extracting the ending should be positive number");
        }

        if (str.Length == 0) 
        {
            throw new ArithmeticException("The lenght of the array used for extracting the ending should not be empty");
        }

        if (str == null) 
        {
            throw new NullReferenceException("The array used for extracting the ending should not be null");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        Console.WriteLine("23 is prime = {0}", CheckPrime(23));
        Console.WriteLine("33 is prime = {0}", CheckPrime(33));

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
