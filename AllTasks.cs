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
using System.Reflection;

namespace Algorithms
{
    public partial class AllTasks : Form
    {
        Form[] tasks;
        int current_task = -1;

        Stopwatch runtime = new Stopwatch();

        public AllTasks()
        {
            InitializeComponent();
        }

        public void runtimeStart(object sender=null, EventArgs e = null)
        {
            runtime.Start();
            //pnlRuntime.Visible = true;
        }

        private void runtimeStop(object sender = null, EventArgs e = null)
        {
            TimeSpan time = runtime.Elapsed;
            lblRuntime.Text = String.Format("{0}.{1:000}", time.Seconds, time.Milliseconds);
            pnlRuntime.Visible = true;
            runtime.Reset();
        }
        public static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            }

            controls.Add(parent);

            return controls;
        }

        private void BindRuntime(Form task)
        {
            GetSelfAndChildrenRecursive(task).OfType<Button>().ToList().ForEach((b) => {
                FieldInfo f1 = typeof(Control).GetField("EventClick",
                    BindingFlags.Static | BindingFlags.NonPublic);
                object obj = f1.GetValue(b);
                PropertyInfo pi = b.GetType().GetProperty("Events",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
                var temp = list[obj]; // old events
                list.RemoveHandler(obj, list[obj]);

                b.Click += runtimeStart; // list.AddHandler(obj, new EventHandler(runtimeStart));
                list.AddHandler(obj, temp);
                b.Click += runtimeStop; // list.AddHandler(obj, new EventHandler(runtimeStop));
            });
        }

        private void ShowTask(Form task)
        {
            task.Show();
            pnlRuntime.Visible = false;

            this.Width++; // костыль, не работает на fullscreen
            this.Width--;
        }

        private void HideTask()
        {
            tasks[current_task].Hide();
            pnlRuntime.Visible = false;
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
            BindRuntime(task);
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
                else if (i == 1) tasks[i] = CreateTask<Task2>();
                //else if (i == 2)
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
