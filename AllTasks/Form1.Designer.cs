
namespace AllTasks
{
    partial class Form1
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
            this.lblSplash = new System.Windows.Forms.Label();
            this.btnTaskExit = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSourceCode,
            this.lblName,
            this.lblCopyright});
            this.statusStrip.Location = new System.Drawing.Point(0, 728);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(760, 26);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
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
            this.task5ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(760, 30);
            this.menuStrip.TabIndex = 4;
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
            this.task2ToolStripMenuItem.Enabled = false;
            this.task2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.task2ToolStripMenuItem.Text = "Task 2";
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.Enabled = false;
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
            // lblSplash
            // 
            this.lblSplash.BackColor = System.Drawing.Color.Black;
            this.lblSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSplash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSplash.Location = new System.Drawing.Point(0, 30);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(760, 698);
            this.lblSplash.TabIndex = 6;
            this.lblSplash.Text = "CHOOSE THE TASK";
            this.lblSplash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTaskExit
            // 
            this.btnTaskExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTaskExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTaskExit.Location = new System.Drawing.Point(5, 34);
            this.btnTaskExit.Name = "btnTaskExit";
            this.btnTaskExit.Size = new System.Drawing.Size(78, 27);
            this.btnTaskExit.TabIndex = 7;
            this.btnTaskExit.Text = "exit task";
            this.btnTaskExit.UseVisualStyleBackColor = true;
            this.btnTaskExit.Visible = false;
            this.btnTaskExit.Click += new System.EventHandler(this.btnTaskExit_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnTaskExit;
            this.ClientSize = new System.Drawing.Size(760, 754);
            this.Controls.Add(this.btnTaskExit);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bouhartsev";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.ToolStripStatusLabel lblSourceCode;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.Button btnTaskExit;
    }
}

