using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests


{
    [TestClass]
    public class RepeatCounterTest
    {
        // [TestMethod]
        // public void MethodName_Spec_ExpectedOutput()
        // {
        //     ClassName instanceName = new ClassName();
        //     Assert.AreEqual(ExpectedOutput, instanceName.MethodName(inputHere));
        // }
        [TestMethod]
        public void Input_HasSpace_True()
        {
            bool isWord = RepeatCounter.IsWord("fat cat");
            Assert.AreEqual(false, isWord);
        }
    }
}