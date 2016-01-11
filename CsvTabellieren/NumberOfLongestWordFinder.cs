using System.Collections.Generic;
using System.Linq;

namespace CsvTabellieren
{
    public class NumberOfLongestWordFinder
    {
        public int[] Execute(IEnumerable<string> CSV_file)
        {
            string firstrow = CSV_file.ToList()[0];
            var result = new int[GetNumberOfColumns(firstrow)];

            foreach (string row in CSV_file)
            {
                string[] words = row.Split(';');

                for (int i = 0; i < GetNumberOfColumns(row); i++)
                {
                    if (words[i].Length > result[i])
                    {
                        result[i] = words[i].Length;
                    }
                }
            }

            return result;
        }

        private int GetNumberOfColumns(string firstrow)
        {
            return firstrow.Split(';').Length;
        }
    }
}
