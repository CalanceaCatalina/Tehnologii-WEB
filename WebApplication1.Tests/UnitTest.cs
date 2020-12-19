using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_GivenAandB_ExpectedResult()
        {
            //arrange - aranjezi toate datele ptu test
            var a = 1;
            var b = 2;

            // act - insusi faci apel la functia care o testezi
            var result = a + b;

            //assert - verifici rezultatul
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2_GivenAandB_ExpectedResult()
        {
            //arrange - aranjezi toate datele ptu test
            var a = 2;
            var b = 2;

            // act - insusi faci apel la functia care o testezi
            double result = System.Math.Pow(a,b);

            //assert - verifici rezultatul
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test3_GivenAandB_ExpectedResult()
        {
            //arrange - aranjezi toate datele ptu test
            var a = 100;
            var b = 20;

            // act - insusi faci apel la functia care o testezi
            var result = a / b;

            //assert - verifici rezultatul
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Meow_Returns_ExpectedString()
        {
            //arrange
            var cat = new Cat();

            //act
            var result = cat.Meow();

            //assert
            Assert.AreEqual("Meow!", result);
        }
    }
    public class Cat
    {
        public string Meow()
        {
            return "Meow!";
        }
    }
}
