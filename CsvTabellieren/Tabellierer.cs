using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvTabellieren
{
    public class Tabellierer
    {
        private NumberOfLongestWordFinder _numberOfLongestWordFinder;
        private int[] _lengthOfLongestWord;
        public Tabellierer()
        {
            _numberOfLongestWordFinder = new NumberOfLongestWordFinder();
        }

        public IEnumerable<string> Tabelliere(IEnumerable<string> CSV_zeilen)
        {
            var result = new List<string>();
            _lengthOfLongestWord = GetLongestWord(CSV_zeilen);

            result.Add(TranslateFirstRow(CSV_zeilen));
            result.Add(CreateSecondRow());

            for (int i = 1; i < CSV_zeilen.Count(); i++)
            {
                var resultRow = new StringBuilder();
                string row = CSV_zeilen.ToList()[i];
                var splittetWords = row.Split(';');

                for (int j = 0; j < splittetWords.Length; j++)
                {
                    string word = splittetWords[j];
                    resultRow.Append(word);
                    fillWithEmptyStrings(_lengthOfLongestWord[j] - word.Length, resultRow);
                    resultRow.Append("|");
                }
                result.Add(resultRow.ToString());
            }

            return result;
        }

        private string TranslateFirstRow(IEnumerable<string> cSV_zeilen)
        {
            var result = new StringBuilder();
            string firstrow = cSV_zeilen.ToList()[0];
            var words = firstrow.Split(';');

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                result.Append(word);
                fillWithEmptyStrings((_lengthOfLongestWord[i] - word.Length), result);
                result.Append("|");
            }
            return result.ToString();
        }

        private string CreateSecondRow()
        {
            var result = new StringBuilder();
            foreach (int length in _lengthOfLongestWord)
            {
                for (int i = 1; i <= length; i++)
                {
                    result.Append("-");
                }
                result.Append("+");
            }
            return result.ToString();
        }

        private void fillWithEmptyStrings(int number, StringBuilder stringBuilder)
        {
            for (int i=0; i< number; i++)
            {
                stringBuilder.Append(" ");
            }
        }


        private int[] GetLongestWord(IEnumerable<string> cSV_zeilen)
        {
            return _numberOfLongestWordFinder.Execute(cSV_zeilen);
        }
    }
}
