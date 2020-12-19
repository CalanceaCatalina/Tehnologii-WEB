using System;
using Xunit;


namespace WebApplication1.Test
{
    public class UnitTests
    {
        [Fact]
        public void Test1_GivenAandB_ExpectedResult()
        {
            //arrange - aranjezi toate datele ptu test

            var a = 1;
            var b = 2;

            // act - insusi faci apel la functia care o testezi
            var result = a + b;

            //assert - verifici rezultatul
            Assert.Equal(3, result);
        }

        [Fact]
        public void Meow_Returns_ExpectedString()
        {
            //arrange
            var cat = new Cat();

            //act
            var result = cat.Meow();

            //assert
            Assert.Equal("Meow!", result);
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
