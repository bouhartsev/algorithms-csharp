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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();

            AllTasks.GetSelfAndChildrenRecursive(this).OfType<Button>().ToList().ForEach((b) => { if (b.Name!="btnRemove") b.Click += new EventHandler(this.pressBtns); });
        }

        private void cmsInput_Opening(object sender, CancelEventArgs e)

        {
            tbInput.Focus();

            // Disable Undo if CanUndo property returns false
            if (tbInput.CanUndo)
            {
                cmsInput.Items["cmsItemUndo"].Enabled = true;
            }
            else
            {
                cmsInput.Items["cmsItemUndo"].Enabled = false;
            }

            // Disable Cut, Copy and Delete if any text is not selected in TextBox

            if (tbInput.SelectedText.Length == 0)

            {

                cmsInput.Items["cmsItemCut"].Enabled = false;

                cmsInput.Items["cmsItemCopy"].Enabled = false;

                cmsInput.Items["cmsItemDelete"].Enabled = false;

            }

            else

            {

                cmsInput.Items["cmsItemCut"].Enabled = true;

                cmsInput.Items["cmsItemCopy"].Enabled = true;

                cmsInput.Items["cmsItemDelete"].Enabled = true;

            }



            // Disable Paste if Clipboard does not contains text

            if (Clipboard.ContainsText())

            {

                cmsInput.Items["cmsItemPaste"].Enabled = true;

            }

            else

            {

                cmsInput.Items["cmsItemPaste"].Enabled = false;

            }



            // Disable Select All if TextBox is blank

            if (tbInput.Text.Length == 0)

            {

                cmsInput.Items["cmsItemSelectAll"].Enabled = false;

            }

            else

            {

                cmsInput.Items["cmsItemSelectAll"].Enabled = true;

            }

        }

        private void cmsItemUndo_Click(object sender, EventArgs e)

        {

            tbInput.Undo();

        }

        private void cmsItemCut_Click(object sender, EventArgs e)

        {

            tbInput.Cut();

        }

        private void cmsItemCopy_Click(object sender, EventArgs e)

        {

            tbInput.Copy();

        }

        private void cmsItemPaste_Click(object sender, EventArgs e)

        {

            tbInput.Paste();

        }

        private void cmsItemDelete_Click(object sender, EventArgs e)

        {

            int SelectionIndex = tbInput.SelectionStart;

            int SelectionCount = tbInput.SelectionLength;

            tbInput.Text = tbInput.Text.Remove(SelectionIndex, SelectionCount);

            tbInput.SelectionStart = SelectionIndex;

        }

        private void cmsItemSelectAll_Click(object sender, EventArgs e)

        {

            tbInput.SelectAll();

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e) // KeyEventArgs
        {
            char key_number = e.KeyChar;

            pressOut(key_number);

            if (!IsAllowedChar(key_number) && key_number != 8 && Control.ModifierKeys != Keys.Control) e.Handled = true;
        }

        private void calc(object sender = null, EventArgs e = null)
        {
            string input = tbInput.Text;
            string result = "";
            if (input == "")
                result = "warning! there is no symbols"; // show error
            else if (!checkAndFix(ref input))
                result = "warning! there is wrong symbols"; // show error
            else
            {
                try
                {
                    string rpn = ConvertToRPN(input); // Преобразовываем выражение в постфиксную запись
                    double answer = CountingRPN(rpn); // Решаем полученное выражение

                    result = answer.ToString();
                }
                catch
                {
                    result = "calc. error! check your expression";
                }
            }
            lblAnswer.Text = result.ToString(); // print result
        }

        private bool checkAndFix(ref string input)
        {
            input = input.Replace(" ", "");
            input = input.Replace('.', ',');
            input = input.Replace('x', '*');
            input = input.Replace('×', '*');
            input = input.Replace('÷', '/');
            input = input.Replace('−', '-');
            tbInput.Text = input;
            if (!Regex.IsMatch(input, @"^[-\d+*^\/(),]+$")) return false;
            return true;
        }

        // convert strings: correct arithmetic to RPN expression 
        private string ConvertToRPN(string input)
        {
            string output = string.Empty; //Строка для хранения выражения
            Stack<char> operStack = new Stack<char>(); //Стек для хранения операторов

            for (int i = 0; i < input.Length; i++) //Для каждого символа в входной строке
            {
                //Разделители пропускаем
                if (IsDelimeter(input[i]))
                    continue; //Переходим к следующему символу

                //Если символ - цифра, то считываем все число
                if (Char.IsDigit(input[i])) //Если цифра
                {
                    //Читаем до разделителя или оператора, что бы получить число
                    while (!IsOperator(input[i]) && !IsDelimeter(input[i]))
                    {
                        output += input[i]; //Добавляем каждую цифру числа к нашей строке

                        i++; //Переходим к следующему символу

                        if (i == input.Length) break; //Если символ - последний, то выходим из цикла
                    }

                    output += " "; //Дописываем после числа пробел в строку с выражением
                    i--; //Возвращаемся на один символ назад, к символу перед разделителем
                }

                //Если символ - оператор
                else if (IsOperator(input[i])) //Если оператор
                {
                    if (input[i] == '(') //Если символ - открывающая скобка
                        operStack.Push(input[i]); //Записываем её в стек
                    else if (input[i] == ')') //Если символ - закрывающая скобка
                    {
                        //Выписываем все операторы до открывающей скобки в строку
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else //Если любой другой оператор
                    {
                        // пока стек не пуст и приоритет текущего оператора меньше или равен значению сверху - добавляем перемещаем оператор из стека в финальную строку
                        while (operStack.Count > 0 && GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                            output += operStack.Pop() + " ";

                        // for negative
                        if (input[i] == '-' &&  (i>0 && input[i - 1] == '(' || i==0)) output += "0 ";
                        
                        operStack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоритет оператора выше - добавляем операторов на вершину стека

                    }
                }
            }

            //Когда прошли по всем символам, выкидываем из стека все оставшиеся там операторы в строку
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; //Возвращаем выражение в постфиксной записи
        }

        // counting Reverse Polish notation
        private double CountingRPN(string input)
        {
            double result = 0; //Результат
            Stack<double> temp = new Stack<double>(); //Временный стек для решения

            for (int i = 0; i < input.Length; i++) //Для каждого символа в строке
            {
                //Если символ - цифра, то читаем все число и записываем на вершину стека
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsOperator(input[i]) && !IsDelimeter(input[i])) //Пока не разделитель
                    {
                        a += input[i]; //Добавляем
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); //Записываем в стек
                    i--;
                }
                else if (IsOperator(input[i])) //Если символ - оператор
                {
                    //Берем два последних значения из стека
                    double a = temp.Pop();
                    double b = temp.Pop();

                    //b = 0;
                    //if (temp.Count > 0 || i != 0)

                    switch (input[i]) //И производим над ними действие, согласно оператору
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }
                    temp.Push(result); //Результат вычисления записываем обратно в стек
                }
            }
            return temp.Peek(); //Забираем результат всех вычислений из стека и возвращаем его
        }

        //Метод возвращает приоритет оператора
        private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 2;
                case '*': return 3;
                case '/': return 3;
                case '^': return 4;
                default: return 5;
            }
        }

        //Метод возвращает true, если проверяемый символ - оператор
        private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

        //Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        private bool IsAllowedChar(char key_number)
        {
            //List<int> KeyCodes = new List<int>() { 94, }; // 8, 35, 36, 37, 39, // KeyCodes.Contains(key_number)

            if (key_number >= 40 && key_number <= 57 || key_number == 94)
                return true;
            return false;
        }

        private void Task3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!tbInput.Focused)
            {
                char key_number = e.KeyChar;
                pressOut(key_number);

                e.Handled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pressOut((char)8);
        }

        private void pressBtns(object sender, EventArgs e)
        {
            pressOut((sender as Button).Text[0]);
        }

        private void pressOut(char key_number)
        {

            if (!tbInput.Focused)
            {
                if (IsAllowedChar(key_number)) tbInput.Text += key_number.ToString();
                else if (key_number == 8)
                    tbInput.Text = tbInput.Text.Remove(tbInput.Text.Length - 1, 1);
                tbInput.SelectionStart = tbInput.Text.Length;
                tbInput.Focus();
            }

            // enter or =
            if (key_number == 61 || key_number == 13) calc();

            // c - очистка поля
            if (key_number=='C' || key_number== 'c' || key_number == 'С' || key_number == 'с')
                tbInput.Text = "";
        }
    }
}
