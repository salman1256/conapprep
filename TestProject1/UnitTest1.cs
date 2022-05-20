using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Welcome to Jenkins";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())

            {
                Console.SetOut(sw);
                ConApp.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
