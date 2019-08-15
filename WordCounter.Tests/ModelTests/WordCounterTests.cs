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
            int output = newCounter.WordNumber();
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void TotalWord_NumOfWOrdInSentence_2()
        {
            RepeatCounter newCounter = new RepeatCounter("cat", "cat cat");
            int output = newCounter.WordNumber();
            Assert.AreEqual(2, output);
        }





    }
}