using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Task8 : Form
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key_pressed = e.KeyChar;

            if (!IsAllowedChar(key_pressed) && key_pressed != 8 && Control.ModifierKeys != Keys.Control) e.Handled = true;
        }

        string isDigit = @"^\d+$";
        string isRoman = @"^[IVXLCDM]+$";

        private bool IsAllowedChar(char key_pressed)
        {
            string input = key_pressed.ToString();
            if (Regex.IsMatch(input, isDigit) || Regex.IsMatch(input, isRoman))
                return true;
            return false;
        }

        Dictionary<string, int> numbers = new Dictionary<string, int> { ["M"] = 1000, ["CM"] = 900, ["D"] = 500, ["CD"] = 400, ["C"] = 100, ["XC"] = 90, ["L"] = 50, ["XL"] = 40, ["X"] = 10, ["IX"] = 9, ["V"] = 5, ["IV"] = 4, ["I"] = 1 };
        private string arabicToRoman(int num)
        {
            string result = "";
            foreach (var item in numbers)
                while (num >= item.Value)
                {
                    result += item.Key;
                    num -= item.Value;
                }
            return result;
        }

        Dictionary<char, int> digits = new Dictionary<char, int> { ['M'] = 1000, ['D'] = 500, ['C'] = 100, ['L'] = 50, ['X'] = 10, ['V'] = 5, ['I'] = 1 };
        private string romanToArabic(string str)
        {
            int r = 0, a = 0, b = 0, c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                a = digits[str[i]];
                b = (i < str.Length - 1) ? digits[str[i + 1]] : 0;
                c = (i < str.Length - 2) ? digits[str[i + 2]] : 0;
                if (b != 0 && (b > a && !numbers.ContainsKey("" + str[i] + str[i + 1]) || a == b && numbers.ContainsValue(a * 2) || c != 0 && a <= b && b < c))
                    throw new Exception("Incorrect Roman number format");
                r += (b > a) ? -a : a;
            }
            return r.ToString();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            string result = "???";
            string info = "Unrecognized";
            try
            {
                if (Regex.IsMatch(input, isDigit))
                {
                    info = "Arabic";
                    int num = Convert.ToInt32(input);
                    if (num <= 0) throw new Exception("Wrong number");

                    result = arabicToRoman(num);
                }
                else if (Regex.IsMatch(input, isRoman))
                {
                    info = "Roman";
                    for (int i = 3; i < input.Length; i++)
                    {
                        char ch = input[i];
                        if (input[i - 3] == ch && input[i - 2] == ch && input[i - 1] == ch) throw new Exception("More than 3 identical symbols consecutively");
                    }

                    result = romanToArabic(input);
                }
            }
            catch
            {
                info = "Error with " + info;
            }
            lblAnswer.Text = result;
            lblInfo.Text = info + " numerals";
        }
    }
}
