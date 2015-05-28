namespace FindLongestSequenceTest
{
    using System;
    using System.Collections.Generic;
    using FindLongestSequence;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestSequenceTest
    {
        [TestMethod]
        public void FindSequenceNormalCase()
        {
            List<int> numbers = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 3, 3, 1, 5, 0, 5, 7
            };

            Assert.AreEqual("3, 3, 3", string.Join(", ", LongestSequence.FindSequence(numbers)));
        }

        [TestMethod]
        public void FindSequenceBorderCase()
        {
            List<int> numbers = new List<int>()
            {
                4, 2, 2, 5, 2, 3, 3, 3, 1, 5, 5, 5, 5
            };

            Assert.AreEqual("5, 5, 5, 5", string.Join(", ", LongestSequence.FindSequence(numbers)));
        }

        [TestMethod]
        public void FindSequenceOneItemCase()
        {
            List<int> numbers = new List<int>()
            {
                4
            };

            Assert.AreEqual("4", string.Join(", ", LongestSequence.FindSequence(numbers)));
        }
    }
}