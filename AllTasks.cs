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

namespace Algorithms
{
    public partial class AllTasks : Form
    {
        Form[] tasks;
        int current_task = -1;

        public AllTasks()
        {
            InitializeComponent();
        }

        private void ShowTask(Form task)
        {
            task.Show();

            this.Width++; // костыль
            this.Width--;
        }

        private void HideTask()
        {
            tasks[current_task].Hide();
            current_task = -1;
            lblSplash.Visible = true;
            btnTaskExit.Visible = false;
        }

        private Form CreateTask<T>() where T : Form, new()
        {
            Form task = new T();
            task.MdiParent = this;
            task.ControlBox = false;
            task.WindowState = FormWindowState.Maximized;
            task.FormBorderStyle = FormBorderStyle.None;
            ShowTask(task);
            return task;
        }

        private void AllTasks_Load(object sender, EventArgs e)
        {
            int len = this.menuStrip.Items.Count;
            tasks = new Form[len];
            for (int i = 0; i < len; i++)
            {
                if (this.menuStrip.Items[i].Enabled) this.menuStrip.Items[i].Click += new System.EventHandler(this.menuItem_Click);
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            lblSplash.Visible = false;
            btnTaskExit.Visible = true;

            int i = Convert.ToInt32((sender as ToolStripItem).Text.Split(' ')[1]) - 1; // У КНОПОК ДОЛЖНЫ БЫТЬ ИМЕНА "Task 1" и т.п.
            if (tasks[i] != null) ShowTask(tasks[i]);
            else
            {
                if (i == 0) tasks[i] = CreateTask<Task1>();
                //else if (i == 1)
            }
            current_task = i;

            // добавить закрытие и удаление предыдущего!!
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            Process.Start("https://bouhartsev.top");
        }

        private void lblSourceCode_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bouhartsev/algorithms-csharp/");
        }

        private void btnTaskExit_Click(object sender, EventArgs e)
        {
            HideTask();
        }
    }
}
