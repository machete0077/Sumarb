using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumarb.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest1()
        {
            //arrange
            SumaController sumaController = new SumaController();
            int a = 2;
            int b = 3;
            int expected = 5;
            //act
            int resultado = sumaController.Add(a, b);
            //assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
