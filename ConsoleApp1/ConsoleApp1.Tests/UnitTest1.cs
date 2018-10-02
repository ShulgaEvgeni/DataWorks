using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RomanToIntTest()
        {
            Assert.AreEqual<int>(16, Program.RomanToInt("XVI"));
            Assert.AreEqual<int>(14, Program.RomanToInt("XIV"));
            Assert.AreEqual<int>(0, Program.RomanToInt("MMMM"));
            Assert.AreEqual<int>(0, Program.RomanToInt("VIIII"));
            Assert.AreEqual<int>(0, Program.RomanToInt("IXI"));
            Assert.AreEqual<int>(0, Program.RomanToInt("XLX"));
            Assert.AreEqual<int>(0, Program.RomanToInt("CDC"));
            Assert.AreEqual<int>(0, Program.RomanToInt("IVIII"));
            Assert.AreEqual<int>(8, Program.RomanToInt("VIII"));
            Assert.AreEqual<int>(70, Program.RomanToInt("LXX"));
            Assert.AreEqual<int>(600, Program.RomanToInt("DC"));
            Assert.AreEqual<int>(900, Program.RomanToInt("CM"));
            Assert.AreEqual<int>(1200, Program.RomanToInt("MCC"));
            Assert.AreEqual<int>(0, Program.RomanToInt(""));
            Assert.AreEqual<int>(0, Program.RomanToInt("qweqs"));
            Assert.AreEqual<int>(0, Program.RomanToInt("XL+M"));
            Assert.AreEqual<int>(0, Program.RomanToInt("X   M"));
        }

        [TestMethod]
        public void BalanceParentheses()
        {            
            Assert.AreEqual<Boolean>(true, Program.BalanceParentheses("((1+3)()(4+(3-5)))"));
            Assert.AreEqual<Boolean>(false, Program.BalanceParentheses(")((1+3)()(4+(3-5)))"));
            Assert.AreEqual<Boolean>(false, Program.BalanceParentheses("()(1+3)()(4+(3-5)))"));
            Assert.AreEqual<Boolean>(false, Program.BalanceParentheses("((1+3)())(4+(3-5)))"));
            Assert.AreEqual<Boolean>(false, Program.BalanceParentheses("((1+3)()(4+(3-5))()"));
        }

        [TestMethod]
        public void DoubleLinkedNode()
        {
            DoubleLinkedNode<int> a1 = new DoubleLinkedNode<int>();            
            int[] a = {19,20,21,22,23,24};
            a1.AddLast(a[2]);
            a1.AddLast(a[3]);
            a1.AddLast(a[4]);
            a1.AddLast(a[5]);
            a1.AddFirst(a[1]);
            a1.AddFirst(a[0]);
            Assert.AreEqual<int>(a.Length, a1.Count);
            Assert.AreEqual<int>(a[0], a1.First.Value);
            Assert.AreEqual<int>(a[5], a1.Last.Value);
            DoubleLinkedNode<int> a2 = a1.First;
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual<int>(a[i], a2.Value);
                if(i < a.Length - 1) a2 = a2.Next;
            }
            a1.Reverse();
            Assert.AreEqual<int>(a.Length, a1.Count);
            Assert.AreEqual<int>(a[5], a1.First.Value);
            Assert.AreEqual<int>(a[0], a1.Last.Value);
            a2 = a1.First;
            for (int i = a.Length - 1; i >= 0 ; i--)
            {
                Assert.AreEqual<int>(a[i], a2.Value);
                if (i > 0) a2 = a2.Next;
            }

        }
    }
}
