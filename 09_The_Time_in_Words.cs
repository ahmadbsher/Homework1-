// HackerRank: The Time in Words (Medium)
// https://www.hackerrank.com/challenges/the-time-in-words/problem
using System;

class Program
{
    static readonly string[] Words = {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
        "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three",
        "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine"
    };

    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int hour = int.Parse(tokens[0]);
        int minute = int.Parse(tokens[1]);
        if (minute == 0) { Console.WriteLine(Words[hour] + " o' clock"); return; }
        if (minute == 15) { Console.WriteLine("quarter past " + Words[hour]); return; }
        if (minute == 30) { Console.WriteLine("half past " + Words[hour]); return; }
        int next = hour == 12 ? 1 : hour + 1;
        if (minute == 45) { Console.WriteLine("quarter to " + Words[next]); return; }

        bool past = minute < 30;
        int count = past ? minute : 60 - minute;
        string unit = count == 1 ? "minute" : "minutes";
        Console.WriteLine(Words[count] + " " + unit + (past ? " past " : " to ") + Words[past ? hour : next]);
    }
}
