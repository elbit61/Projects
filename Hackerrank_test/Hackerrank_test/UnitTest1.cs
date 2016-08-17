using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hackerrank_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        private bool IsOdd(int x)
        {
            return x % 2 != 0;
        }

        [TestMethod]
        public void TestMethod2()
        {
            int N = 2;

            if(N < 2 || N > 20)
                Console.WriteLine("N must be 2 <= N <= 20");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(N + " * " + i + " = " + (N*i));
            }
        }
    }
}
