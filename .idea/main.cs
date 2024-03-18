using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 5, 8, 20, 15 };
        int max = numbers.Max();
        Console.WriteLine($"The maximum value in the array is: {max}");
    }
}