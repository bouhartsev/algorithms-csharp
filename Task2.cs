using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        List<int> array = new List<int>();
        private void printArray(object sender = null, EventArgs e = null)
        {
            listView.Clear();
            if (array?.Count > 0)
            {
                //this.lblList.Text = String.Join("\n", array.Select((x, ind) => ind + ": " + x)); // for label
                string temp = "";
                listView.Items.AddRange(array.Select((x, ind) => {
                    temp = ind + ":   ";
                    if (ind / 10 == 0) temp += "  ";
                    temp += x;
                    return new ListViewItem(temp);
                }).ToArray());

                btnBackToArray.Enabled = true;
                btnSort.Enabled = true;
            }
            else
            {
                btnBackToArray.Enabled = false;
                btnSort.Enabled = false;
            }
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            array = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < inpCreateLength.Value; i++)
            {
                array.Add(rand.Next(-100000, 100000));
            }
        }
    }
}
