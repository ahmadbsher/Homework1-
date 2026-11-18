// HackerRank: Extra Long Factorials (Medium)
// https://www.hackerrank.com/challenges/extra-long-factorials/problem
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine().Trim());
        BigInteger factorial = BigInteger.One;
        for (int i = 2; i <= n; i++) factorial *= i;
        Console.WriteLine(factorial);
    }
}
