using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }



        //test cases[  ]

        string[] caseTrue = { "", "[]", "[[]]", "[[[]]]", "[[[[]]]]", "[][]" };
        string[] caseFalse = { "]", "[", "][", "[[", "]]", "[[]", "[]]" };


        [TestMethod]
        public void True0()
        {
            string testStr = caseTrue[0];
            bool expected =true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void True1()
        {
            string testStr = caseTrue[1];
            bool expected = true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void True2()
        {
            string testStr = caseTrue[2];
            bool expected = true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void True3()
        {
            string testStr = caseTrue[3];
            bool expected = true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void True4()
        {
            string testStr = caseTrue[4];
            bool expected = true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void True5()
        {
            string testStr = caseTrue[5];
            bool expected = true;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }




        [TestMethod]
        public void False0()
        {
            string testStr = caseFalse[0];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False1()
        {
            string testStr = caseFalse[1];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False2()
        {
            string testStr = caseFalse[2];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False3()
        {
            string testStr = caseFalse[3];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False4()
        {
            string testStr = caseFalse[4];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False5()
        {
            string testStr = caseFalse[5];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void False6()
        {
            string testStr = caseFalse[6];
            bool expected = false;
            bool actual = BalancedBrackets.HasBalancedBrackets(testStr);

            Assert.AreEqual(expected, actual);
        }









    }
}
