

using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            string str = "12 4 is the best place to learn and practice coding!";
            var parts = str.Split(' ');
            int i2 = Convert.ToInt32(parts[0]);
            double d2 = Convert.ToDouble(parts[1]);
            string s2 = Convert.ToString(parts[2]);

            Console.WriteLine(i+i2);
            Console.WriteLine(Math.Round((d + d2), 2));
            Console.WriteLine(s + s2);
        }
    }
}
