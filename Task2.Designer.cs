
namespace Algorithms
{
    partial class Task2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.inpCreateLength = new System.Windows.Forms.NumericUpDown();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.btnBackToArray = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.lblArray = new System.Windows.Forms.Label();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.rbInsertion = new System.Windows.Forms.RadioButton();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblActions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inpCreateLength)).BeginInit();
            this.gbCreate.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(653, 60);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Sorting";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpCreateLength
            // 
            this.inpCreateLength.BackColor = System.Drawing.Color.Black;
            this.inpCreateLength.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpCreateLength.Location = new System.Drawing.Point(9, 79);
            this.inpCreateLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inpCreateLength.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.inpCreateLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpCreateLength.Name = "inpCreateLength";
            this.inpCreateLength.Size = new System.Drawing.Size(83, 22);
            this.inpCreateLength.TabIndex = 2;
            this.inpCreateLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateArray.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateArray.Location = new System.Drawing.Point(109, 21);
            this.btnCreateArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(227, 44);
            this.btnCreateArray.TabIndex = 0;
            this.btnCreateArray.Text = "Create new array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // gbCreate
            // 
            this.gbCreate.BackColor = System.Drawing.Color.Transparent;
            this.gbCreate.Controls.Add(this.btnBackToArray);
            this.gbCreate.Controls.Add(this.lblLength);
            this.gbCreate.Controls.Add(this.inpCreateLength);
            this.gbCreate.Controls.Add(this.btnCreateArray);
            this.gbCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCreate.Location = new System.Drawing.Point(13, 105);
            this.gbCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCreate.Size = new System.Drawing.Size(357, 146);
            this.gbCreate.TabIndex = 20;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Array";
            // 
            // btnBackToArray
            // 
            this.btnBackToArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToArray.Enabled = false;
            this.btnBackToArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToArray.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackToArray.Location = new System.Drawing.Point(109, 79);
            this.btnBackToArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToArray.Name = "btnBackToArray";
            this.btnBackToArray.Size = new System.Drawing.Size(227, 42);
            this.btnBackToArray.TabIndex = 6;
            this.btnBackToArray.Text = "Back to random array";
            this.btnBackToArray.UseVisualStyleBackColor = true;
            this.btnBackToArray.Click += new System.EventHandler(this.btnBackToArray_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(7, 47);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(85, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Array length";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.Black;
            this.listView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(513, 105);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(121, 333);
            this.listView.TabIndex = 25;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(548, 74);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(55, 17);
            this.lblArray.TabIndex = 21;
            this.lblArray.Text = "ARRAY";
            // 
            // rbSelection
            // 
            this.rbSelection.AutoSize = true;
            this.rbSelection.Location = new System.Drawing.Point(9, 55);
            this.rbSelection.Margin = new System.Windows.Forms.Padding(4);
            this.rbSelection.Name = "rbSelection";
            this.rbSelection.Size = new System.Drawing.Size(115, 21);
            this.rbSelection.TabIndex = 7;
            this.rbSelection.Text = "Selection sort";
            this.rbSelection.UseVisualStyleBackColor = true;
            // 
            // rbInsertion
            // 
            this.rbInsertion.AutoSize = true;
            this.rbInsertion.Checked = true;
            this.rbInsertion.Location = new System.Drawing.Point(9, 26);
            this.rbInsertion.Margin = new System.Windows.Forms.Padding(4);
            this.rbInsertion.Name = "rbInsertion";
            this.rbInsertion.Size = new System.Drawing.Size(111, 21);
            this.rbInsertion.TabIndex = 6;
            this.rbInsertion.TabStop = true;
            this.rbInsertion.Text = "Insertion sort";
            this.rbInsertion.UseVisualStyleBackColor = true;
            // 
            // gbSort
            // 
            this.gbSort.BackColor = System.Drawing.Color.Transparent;
            this.gbSort.Controls.Add(this.rbQuick);
            this.gbSort.Controls.Add(this.rbMerge);
            this.gbSort.Controls.Add(this.rbSelection);
            this.gbSort.Controls.Add(this.rbInsertion);
            this.gbSort.Controls.Add(this.btnSort);
            this.gbSort.Enabled = false;
            this.gbSort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSort.Location = new System.Drawing.Point(13, 278);
            this.gbSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSort.Name = "gbSort";
            this.gbSort.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSort.Size = new System.Drawing.Size(357, 160);
            this.gbSort.TabIndex = 23;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sorting";
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Location = new System.Drawing.Point(9, 112);
            this.rbQuick.Margin = new System.Windows.Forms.Padding(4);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(89, 21);
            this.rbQuick.TabIndex = 9;
            this.rbQuick.Text = "Quicksort";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbMerge
            // 
            this.rbMerge.AutoSize = true;
            this.rbMerge.Location = new System.Drawing.Point(9, 84);
            this.rbMerge.Margin = new System.Windows.Forms.Padding(4);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(97, 21);
            this.rbMerge.TabIndex = 8;
            this.rbMerge.Text = "Merge sort";
            this.rbMerge.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSort.Location = new System.Drawing.Point(185, 26);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(151, 107);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort array";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(172, 74);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(68, 17);
            this.lblActions.TabIndex = 26;
            this.lblActions.Text = "ACTIONS";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(653, 459);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.gbSort);
            this.Controls.Add(this.lblActions);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Task2";
            this.Text = "Task 2";
            ((System.ComponentModel.ISupportInitialize)(this.inpCreateLength)).EndInit();
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown inpCreateLength;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.RadioButton rbInsertion;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnBackToArray;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbMerge;
    }
}