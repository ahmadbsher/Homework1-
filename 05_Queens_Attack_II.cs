// HackerRank: Queen's Attack II (Medium)
// https://www.hackerrank.com/challenges/queens-attack-2/problem
using System;

class Program
{
    static void Main()
    {
        string[] tokens = Console.In.ReadToEnd().Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
        int at = 0;
        int n = int.Parse(tokens[at++]);
        int k = int.Parse(tokens[at++]);
        int qr = int.Parse(tokens[at++]);
        int qc = int.Parse(tokens[at++]);

        int north = n - qr, south = qr - 1, east = n - qc, west = qc - 1;
        int ne = Math.Min(north, east), nw = Math.Min(north, west);
        int se = Math.Min(south, east), sw = Math.Min(south, west);

        for (int i = 0; i < k; i++)
        {
            int row = int.Parse(tokens[at++]);
            int col = int.Parse(tokens[at++]);
            int dr = row - qr, dc = col - qc;
            if (dc == 0)
            {
                if (dr > 0) north = Math.Min(north, dr - 1);
                else if (dr < 0) south = Math.Min(south, -dr - 1);
            }
            else if (dr == 0)
            {
                if (dc > 0) east = Math.Min(east, dc - 1);
                else west = Math.Min(west, -dc - 1);
            }
            else if (Math.Abs(dr) == Math.Abs(dc))
            {
                int distance = Math.Abs(dr) - 1;
                if (dr > 0 && dc > 0) ne = Math.Min(ne, distance);
                else if (dr > 0 && dc < 0) nw = Math.Min(nw, distance);
                else if (dr < 0 && dc > 0) se = Math.Min(se, distance);
                else sw = Math.Min(sw, distance);
            }
        }
        Console.WriteLine(north + south + east + west + ne + nw + se + sw);
    }
}
