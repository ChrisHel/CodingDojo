using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CsvTabellieren.Tests
{
    [TestFixture]
    public class NumberOfLongestWordFinderTest
    {
        [Test]
        public void Execute_3ZeilenPovided_GetCorrectNumbers()
        {
            //Arrange
            var input = new List<string>();
            input.Add("Name;Strasse;Ort;Alter");
            input.Add("Peter Pan;Am Hang 5;12345 Einsam;42");
            input.Add("Maria Schmitz;Kölner Straße 45; 50123 Köln; 43");

            var numberOfLongestWordFinder = new NumberOfLongestWordFinder();

            //Act
            var result = numberOfLongestWordFinder.Execute(input);

            //Assert
            Assert.That(result.ToList()[0], Is.EqualTo(13));
            Assert.That(result.ToList()[1], Is.EqualTo(16));
            Assert.That(result.ToList()[2], Is.EqualTo(12));
            Assert.That(result.ToList()[3], Is.EqualTo(5));
        }
    }
}
