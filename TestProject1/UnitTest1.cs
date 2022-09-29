using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using TextClassification.Domain;
using TextClassification.FileIO;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
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

            File testerFile = new File();

            List<string> expected = new List<string>();
            expected.Add("bbcsportsfootball");
            expected.Add("dailymirrornfl");
            expected.Add("sunsportsboxing");

            // act
            // TODO

            List<string> actual = File.getAllFileNames("ClassA");
            foreach(var file in actual)
            {
                Debug.WriteLine(file.ToString());
            }

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}