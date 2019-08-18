using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests


{
    [TestClass]
    public class WordCounterTest
    {
        // [TestMethod]
        // public void MethodName_Spec_ExpectedOutput()
        // {
        //     ClassName instanceName = new ClassName();
        //     Assert.AreEqual(ExpectedOutput, instanceName.MethodName(inputHere));
        // }
        [TestMethod]
        public void TotalWord_NumOfWord_1()
        {
            RepeatCounter newCounter = new RepeatCounter("cat", "cat");
            int totalWords = newCounter.WordNumber();
            Assert.AreEqual(1, totalWords);
        }

        [TestMethod]
        public void TotalWord_NoneBecauseConnected_0()
        {
            RepeatCounter newCounter = new RepeatCounter("cat", "catcat");
            int totalWords = newCounter.WordNumber();
            Assert.AreEqual(0, totalWords);
        }
        [TestMethod]
        public void TotalWord_MultipleInSentence_2()
        {
            RepeatCounter newCounter = new RepeatCounter("cat hat", "cat");
            int totalWords = newCounter.WordNumber();
            Assert.AreEqual(1, totalWords);
        }

        [TestMethod]
        public void TotalWord_MultipleCats_3()
        {
            RepeatCounter newCounter = new RepeatCounter("cat cat hat mat categories cat", "cat");
            int totalWords = newCounter.WordNumber();
            Assert.AreEqual(3, totalWords);
        }





    }
}