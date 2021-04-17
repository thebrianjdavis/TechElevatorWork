using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        Exercises.WordCount wordCount = new WordCount();
        [TestMethod]
        public void WordsCountCorrectly()
        {
            string[] words = new string[] { "ba", "ba", "black", "sheep" };
            Dictionary<string, int> testDict = new Dictionary<string, int>();
            testDict.Add("ba", 2);
            testDict.Add("black", 1);
            testDict.Add("sheep", 1);
            Dictionary<string, int> result = wordCount.GetCount(words);
            CollectionAssert.AreEqual(testDict, result);
        }
        [TestMethod]
        public void CharsCountCorrectly()
        {
            string[] words = new string[] { "a", "b", "c", "a", "b" };
            Dictionary<string, int> testDict = new Dictionary<string, int>();
            testDict.Add("a", 2);
            testDict.Add("b", 2);
            testDict.Add("c", 1);
            Dictionary<string, int> result = wordCount.GetCount(words);
            CollectionAssert.AreEqual(testDict, result);
        }
        [TestMethod]
        public void NothingReturnsNothing()
        {
            string[] words = new string[] { };
            Dictionary<string, int> testDict = new Dictionary<string, int>();
            Dictionary<string, int> result = wordCount.GetCount(words);
            CollectionAssert.AreEqual(testDict, result);
        }
    }
}
