using CsvTabellieren;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CsvTabellierenTests
{
    public class CsvTabelliererTests
    {
        [TestCase("Name;Strasse;Ort;Alter", "Name|Strasse|Ort|Alter|")]
        [TestCase("Name;Ort;Alter;Strasse", "Name|Ort|Alter|Strasse|")]
        public void Tabelliere_eineZeileAlsInput_gewuenschterOutput(string inputzeile, string expected)
        {
            //Arrange
            var input = new List<string>();
            input.Add(inputzeile);

            var tabellierer = new Tabellierer();

            //Act
            var result = tabellierer.Tabelliere(input);

            //Assert
            Assert.That(result.ToList()[0], Is.EqualTo(expected));
        }

        [Test]
        public void Tabelliere_zweiZeilenAlsInput_gewuenschterOutput()
        {
            //Arrange
            var input = new List<string>();
            input.Add("Name;Strasse;Ort;Alter");
            input.Add("Peter Pan;Am Hang 5;12345 Einsam;42");

            var tabellierer = new Tabellierer();

            //Act
            var result = tabellierer.Tabelliere(input);

            //Assert
            Assert.That(result.ToList()[0], Is.EqualTo("Name     |Strasse  |Ort         |Alter|"));
            Assert.That(result.ToList()[1], Is.EqualTo("---------+---------+------------+-----+"));
            Assert.That(result.ToList()[2], Is.EqualTo("Peter Pan|Am Hang 5|12345 Einsam|42   |"));
        }
    }
}
