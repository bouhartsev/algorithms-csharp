
namespace Algorithms
{
    partial class AllTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTasks));
            this.lblSplash = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblSourceCode = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaskExit = new System.Windows.Forms.Button();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.pnlRuntime = new System.Windows.Forms.Panel();
            this.lblRuntimeTitle = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnlRuntime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSplash
            // 
            this.lblSplash.BackColor = System.Drawing.Color.Black;
            this.lblSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSplash.Location = new System.Drawing.Point(0, 30);
            this.lblSplash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(532, 493);
            this.lblSplash.TabIndex = 10;
            this.lblSplash.Text = "CHOOSE THE TASK";
            this.lblSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSourceCode,
            this.lblName,
            this.lblCopyright});
            this.statusStrip.Location = new System.Drawing.Point(0, 523);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(532, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "Footer";
            // 
            // lblSourceCode
            // 
            this.lblSourceCode.IsLink = true;
            this.lblSourceCode.LinkColor = System.Drawing.Color.White;
            this.lblSourceCode.Margin = new System.Windows.Forms.Padding(4, 4, 20, 2);
            this.lblSourceCode.Name = "lblSourceCode";
            this.lblSourceCode.Size = new System.Drawing.Size(93, 20);
            this.lblSourceCode.Text = "Source Code";
            this.lblSourceCode.ToolTipText = "GitHub";
            this.lblSourceCode.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lblSourceCode.Click += new System.EventHandler(this.lblSourceCode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoToolTip = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.IsLink = true;
            this.lblName.LinkColor = System.Drawing.Color.White;
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 4, -3, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 20);
            this.lblName.Text = "Matvey Bouhartsev";
            this.lblName.ToolTipText = "https://bouhartsev.top";
            this.lblName.VisitedLinkColor = System.Drawing.Color.Silver;
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(58, 20);
            this.lblCopyright.Text = "© 2022";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task1ToolStripMenuItem,
            this.task2ToolStripMenuItem,
            this.task3ToolStripMenuItem,
            this.task4ToolStripMenuItem,
            this.task5ToolStripMenuItem,
            this.task6ToolStripMenuItem,
            this.task7ToolStripMenuItem,
            this.task8ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(532, 30);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task1ToolStripMenuItem.Text = "Task 1";
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task2ToolStripMenuItem.Text = "Task 2";
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            this.task3ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task3ToolStripMenuItem.Text = "Task 3";
            // 
            // task4ToolStripMenuItem
            // 
            this.task4ToolStripMenuItem.Enabled = false;
            this.task4ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task4ToolStripMenuItem.Name = "task4ToolStripMenuItem";
            this.task4ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task4ToolStripMenuItem.Text = "Task 4";
            // 
            // task5ToolStripMenuItem
            // 
            this.task5ToolStripMenuItem.Enabled = false;
            this.task5ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task5ToolStripMenuItem.Name = "task5ToolStripMenuItem";
            this.task5ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task5ToolStripMenuItem.Text = "Task 5";
            // 
            // task6ToolStripMenuItem
            // 
            this.task6ToolStripMenuItem.Enabled = false;
            this.task6ToolStripMenuItem.Name = "task6ToolStripMenuItem";
            this.task6ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task6ToolStripMenuItem.Text = "Task 6";
            // 
            // task7ToolStripMenuItem
            // 
            this.task7ToolStripMenuItem.Enabled = false;
            this.task7ToolStripMenuItem.Name = "task7ToolStripMenuItem";
            this.task7ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task7ToolStripMenuItem.Text = "Task 7";
            // 
            // task8ToolStripMenuItem
            // 
            this.task8ToolStripMenuItem.Enabled = false;
            this.task8ToolStripMenuItem.Name = "task8ToolStripMenuItem";
            this.task8ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task8ToolStripMenuItem.Text = "Task 8";
            // 
            // btnTaskExit
            // 
            this.btnTaskExit.BackColor = System.Drawing.Color.Black;
            this.btnTaskExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTaskExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaskExit.Location = new System.Drawing.Point(9, 38);
            this.btnTaskExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaskExit.Name = "btnTaskExit";
            this.btnTaskExit.Size = new System.Drawing.Size(58, 22);
            this.btnTaskExit.TabIndex = 11;
            this.btnTaskExit.Text = "exit task";
            this.btnTaskExit.UseVisualStyleBackColor = false;
            this.btnTaskExit.Visible = false;
            this.btnTaskExit.Click += new System.EventHandler(this.btnTaskExit_Click);
            // 
            // lblRuntime
            // 
            this.lblRuntime.Location = new System.Drawing.Point(0, 24);
            this.lblRuntime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lblRuntime.Size = new System.Drawing.Size(54, 14);
            this.lblRuntime.TabIndex = 14;
            this.lblRuntime.Text = "0.0000";
            this.lblRuntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRuntime
            // 
            this.pnlRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRuntime.Controls.Add(this.lblRuntimeTitle);
            this.pnlRuntime.Controls.Add(this.lblRuntime);
            this.pnlRuntime.Location = new System.Drawing.Point(458, 29);
            this.pnlRuntime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRuntime.Name = "pnlRuntime";
            this.pnlRuntime.Size = new System.Drawing.Size(55, 46);
            this.pnlRuntime.TabIndex = 16;
            this.pnlRuntime.Visible = false;
            // 
            // lblRuntimeTitle
            // 
            this.lblRuntimeTitle.Location = new System.Drawing.Point(0, 4);
            this.lblRuntimeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuntimeTitle.Name = "lblRuntimeTitle";
            this.lblRuntimeTitle.Size = new System.Drawing.Size(54, 19);
            this.lblRuntimeTitle.TabIndex = 15;
            this.lblRuntimeTitle.Text = "Runtime:";
            this.lblRuntimeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnTaskExit;
            this.ClientSize = new System.Drawing.Size(532, 549);
            this.Controls.Add(this.pnlRuntime);
            this.Controls.Add(this.btnTaskExit);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AllTasks";
            this.Text = "Bouhartsev";
            this.Load += new System.EventHandler(this.AllTasks_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlRuntime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblSourceCode;
        private System.Windows.Forms.ToolStripStatusLabel lblName;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task5ToolStripMenuItem;
        private System.Windows.Forms.Button btnTaskExit;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Panel pnlRuntime;
        private System.Windows.Forms.Label lblRuntimeTitle;
        private System.Windows.Forms.ToolStripMenuItem task6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task8ToolStripMenuItem;
    }
}

