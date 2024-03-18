using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] value_numbers = { 10, 5, 8, 20, 15 };
        int max = value_numbers.Max();
        Console.WriteLine($"The maximum value in the array is: {max}");
    }
}