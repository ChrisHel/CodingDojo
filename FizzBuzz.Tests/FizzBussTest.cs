using NSubstitute;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Execute_NomrmalBehaviour_ExpectedOutput()
        {
            //Arrange
            var mockConsoleWriter = Substitute.For<IConsoleWriter>();
            var fizzBuzzExecuter = new FizzBuzzExecuter(mockConsoleWriter);

            //Act
            fizzBuzzExecuter.Execute();

            //Assert
            
        }
    }
}
