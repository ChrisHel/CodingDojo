using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CsvTabellieren
{
    public partial class CsvTabellierenForm : Form
    {
        private Tabellierer _tabellierer;

        public CsvTabellierenForm()
        {
            InitializeComponent();
            _tabellierer = new Tabellierer();
        }

        private void translateButton_Click(object sender, System.EventArgs e)
        {
            var input = GetInputFromInputBox();
            WriteTralatetDataToOutput(_tabellierer.Tabelliere(input));
        }

        private IEnumerable<string> GetInputFromInputBox()
        {
            var result = new List<string>();
            foreach (string line in InputTextBox.Lines)
            {
                result.Add(line);
            }
            return result;
        }

        private void WriteTralatetDataToOutput(IEnumerable<string> output)
        {
            outputTextBox.Text = string.Empty;
            foreach (string line in output)
            {
                outputTextBox.Text += line;
                outputTextBox.Text += Environment.NewLine;
            }
        }

    }
}
