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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            AllTasks.GetSelfAndChildrenRecursive(this).OfType<Button>().ToList().ForEach((b) => { if (b.Name!="btnSearch") b.Click += new EventHandler(this.printArray); });
        }

        List<int> array = new List<int>();
        bool sorted = false;

        private void printArray(object sender=null, EventArgs e = null)
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

                if (!gbSearch.Enabled)
                {
                    gbSearch.Enabled = true;
                    gbDelete.Enabled = true;
                }

                if (array.Count == 25) gbInsert.Enabled = false;
                else gbInsert.Enabled = true;

                inpInsertIndex.Maximum = array.Count;
                inpDeleteIndex.Maximum = array.Count - 1;
            }
            else
            {
                gbSearch.Enabled = false;
                gbDelete.Enabled = false;
                gbInsert.Enabled = true;
                inpInsertIndex.Maximum = 0;
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

            sorted = rbSorted.Checked;

            if (sorted)
            {
                array.Sort();
                inpInsertIndex.Enabled = false;
            }
            else inpInsertIndex.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // multiselect for same values

            foreach (ListViewItem item in listView.SelectedItems)
                item.Selected = false;
            List<int> result = new List<int>();
            int toFind = Convert.ToInt32(inpSearchValue.Value);
            int ind;
            if (!sorted)
            {
                ind = array.FindIndex(x => x == toFind);
                while (ind >= 0)
                {
                    result.Add(ind);
                    ind = array.FindIndex(ind + 1, x => x == toFind);
                }
            }
            else
            {
                ind = array.BinarySearch(toFind);
                if (ind >= 0)
                {
                    result.Add(ind);
                    while (ind < array.Count - 1 && array[++ind] == toFind)
                        result.Add(ind);
                }
            }

            for (int i = 0; i < result.Count; i++) listView.Items[result[i]].Selected = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int toInsert = Convert.ToInt32(inpInsertValue.Value);
            if (!sorted) array.Insert(Convert.ToInt32(inpInsertIndex.Value), toInsert);
            else
            {
                int ind = array.BinarySearch(toInsert);
                if (ind < 0) ind = ~ind;
                array.Insert(ind, toInsert);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            array.RemoveAt(Convert.ToInt32(inpDeleteIndex.Value));
        }
    }
}
