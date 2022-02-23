using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AllTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form CreateTask<T>() where T : Form, new()
        {
            
            Form task = new T();
            task.MdiParent = this;
            task.ControlBox = false;
            task.WindowState = FormWindowState.Maximized;
            task.FormBorderStyle = FormBorderStyle.None;
            task.Show();
            this.Width++; // костыль
            this.Width--;
            return task;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form task = CreateTask<Task1.Form1>();
            // task.Show();
            // добавить закрытие и удаление предыдущего!!
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Process.Start("https://bouhartsev.top");
        }
    }
}
