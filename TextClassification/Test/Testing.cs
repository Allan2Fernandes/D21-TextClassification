using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TextClassification.Controller;
using TextClassification.Domain;

namespace Test
{
    [TestClass]
    public class Testing
    {

        [TestMethod]
        public void TestWordItem()
        {
            // arrange
            string expected = "nice";
            WordItem wI = new WordItem("nice", 0);

            // act
            string actual = wI.GetWord();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestFileListBuilder()
        {
            // arrange
            // (A part only)
            
            List<string> expected = new List<string>();
            expected.Add("bbcsportsfootball");
            expected.Add("dailymirrornfl");
            expected.Add("sunsportsboxing");

            // act
            // TODO

            List<string> actual = new List<string>();


            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
