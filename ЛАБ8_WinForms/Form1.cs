using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ЛАБ8_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static IEnumerable<double> GetNumbers(string input)
        {
            var matches = Regex.Matches(input, @"-?\d+(?:\.\d+)?", RegexOptions.Compiled);
            return from Match match in matches select double.Parse(match.Value, CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text;
            var nums = GetNumbers(s);
            if (nums.Any())
                textBox2.Text = nums.Max().ToString();
            else
                textBox2.Text = "Нет чисел!";
        }
    }
}
