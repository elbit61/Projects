using System;

#pragma warning disable 1587
/// <summary>
/// Task: Day 6: Let's Review
/// https://www.hackerrank.com/challenges/30-review-loop?h_r=next-challenge&h_v=zen
/// </summary>
#pragma warning restore 1587

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountRaw = Cons.ReadLine();
            var T = int.Parse(amountRaw);

            if (T < 1 || T > 10)
                throw new Exception("T must be in interval 1 <= T <= 10");

            for (var i = 0; i < T; i++)
            {
                var s = Cons.ReadLine();

                var length = s.Length;
                if (length < 1 || length > 10000)
                    throw new Exception("Length must be in interval 2 <= Length <= 10000");

                string oddIndexed = null;
                string evenIndexed = null;

                for (int j = 0; j < length; j++)
                {
                    if (Helper.IsOdd(j))
                        oddIndexed = oddIndexed + s[j];
                    else
                    {
                        evenIndexed = evenIndexed + s[j];
                    }
                }
                Console.WriteLine("'evenIndexed' 'oddIndexed'");
                Console.ReadLine();
            }
        }
    }

    public sealed class Solution
    {
        
    }

    public static class Cons
    {
        private static int _pos = 0;

        private static string[] _lines = new []{ "2", "Hacker", "Rank" };
        
        public static string ReadLine()
        {
            return _lines[_pos++];
        }
    }
}
