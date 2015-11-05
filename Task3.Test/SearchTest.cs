using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3.Test
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void BinarySearch_12345_5_result4()
        {
            int[] array = {8,9,10,11,12};
            int item = 12;

            int expectedResult = 4;

            Assert.AreEqual(expectedResult, array.BinarySearch<int>(item));
        }

        [TestMethod]
        public void BinarySearch_stringArray_result2()
        {
            string[] array = { "ready","stady","to","go" };
            string item = "to";

            int expectedResult = 2;

            Assert.AreEqual(expectedResult, array.BinarySearch<string>(item));
        }
    }
}
