using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NedospasovaAE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Александра";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Александра", res);
        }
    }
}
