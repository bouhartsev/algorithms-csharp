
namespace Algorithms
{
    partial class Task1
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
            this.lblActions = new System.Windows.Forms.Label();
            this.lblDeleteIndex = new System.Windows.Forms.Label();
            this.inpDeleteIndex = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.inpInsertIndex = new System.Windows.Forms.NumericUpDown();
            this.lblInsertValue = new System.Windows.Forms.Label();
            this.inpInsertValue = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblSearchValue = new System.Windows.Forms.Label();
            this.inpSearchValue = new System.Windows.Forms.NumericUpDown();
            this.lblInsertIndex = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.rbSorted = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.inpCreateLength = new System.Windows.Forms.NumericUpDown();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inpDeleteIndex)).BeginInit();
            this.gbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpInsertIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpInsertValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSearchValue)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpCreateLength)).BeginInit();
            this.gbInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(171, 65);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(68, 17);
            this.lblActions.TabIndex = 18;
            this.lblActions.Text = "ACTIONS";
            // 
            // lblDeleteIndex
            // 
            this.lblDeleteIndex.AutoSize = true;
            this.lblDeleteIndex.Location = new System.Drawing.Point(10, 30);
            this.lblDeleteIndex.Name = "lblDeleteIndex";
            this.lblDeleteIndex.Size = new System.Drawing.Size(41, 17);
            this.lblDeleteIndex.TabIndex = 5;
            this.lblDeleteIndex.Text = "Index";
            // 
            // inpDeleteIndex
            // 
            this.inpDeleteIndex.BackColor = System.Drawing.Color.Black;
            this.inpDeleteIndex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpDeleteIndex.Location = new System.Drawing.Point(60, 28);
            this.inpDeleteIndex.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inpDeleteIndex.Name = "inpDeleteIndex";
            this.inpDeleteIndex.Size = new System.Drawing.Size(113, 22);
            this.inpDeleteIndex.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(207, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.BackColor = System.Drawing.Color.Transparent;
            this.gbDelete.Controls.Add(this.lblDeleteIndex);
            this.gbDelete.Controls.Add(this.inpDeleteIndex);
            this.gbDelete.Controls.Add(this.btnDelete);
            this.gbDelete.Enabled = false;
            this.gbDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbDelete.Location = new System.Drawing.Point(12, 485);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(358, 75);
            this.gbDelete.TabIndex = 15;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Delete from array";
            // 
            // inpInsertIndex
            // 
            this.inpInsertIndex.BackColor = System.Drawing.Color.Black;
            this.inpInsertIndex.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpInsertIndex.Location = new System.Drawing.Point(60, 59);
            this.inpInsertIndex.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.inpInsertIndex.Name = "inpInsertIndex";
            this.inpInsertIndex.Size = new System.Drawing.Size(113, 22);
            this.inpInsertIndex.TabIndex = 6;
            // 
            // lblInsertValue
            // 
            this.lblInsertValue.AutoSize = true;
            this.lblInsertValue.Location = new System.Drawing.Point(10, 30);
            this.lblInsertValue.Name = "lblInsertValue";
            this.lblInsertValue.Size = new System.Drawing.Size(44, 17);
            this.lblInsertValue.TabIndex = 5;
            this.lblInsertValue.Text = "Value";
            // 
            // inpInsertValue
            // 
            this.inpInsertValue.BackColor = System.Drawing.Color.Black;
            this.inpInsertValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpInsertValue.Location = new System.Drawing.Point(60, 28);
            this.inpInsertValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inpInsertValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.inpInsertValue.Name = "inpInsertValue";
            this.inpInsertValue.Size = new System.Drawing.Size(113, 22);
            this.inpInsertValue.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInsert.Location = new System.Drawing.Point(207, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 51);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblSearchValue
            // 
            this.lblSearchValue.AutoSize = true;
            this.lblSearchValue.Location = new System.Drawing.Point(10, 30);
            this.lblSearchValue.Name = "lblSearchValue";
            this.lblSearchValue.Size = new System.Drawing.Size(44, 17);
            this.lblSearchValue.TabIndex = 5;
            this.lblSearchValue.Text = "Value";
            // 
            // inpSearchValue
            // 
            this.inpSearchValue.BackColor = System.Drawing.Color.Black;
            this.inpSearchValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpSearchValue.Location = new System.Drawing.Point(60, 28);
            this.inpSearchValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inpSearchValue.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.inpSearchValue.Name = "inpSearchValue";
            this.inpSearchValue.Size = new System.Drawing.Size(113, 22);
            this.inpSearchValue.TabIndex = 2;
            // 
            // lblInsertIndex
            // 
            this.lblInsertIndex.AutoSize = true;
            this.lblInsertIndex.Location = new System.Drawing.Point(10, 61);
            this.lblInsertIndex.Name = "lblInsertIndex";
            this.lblInsertIndex.Size = new System.Drawing.Size(41, 17);
            this.lblInsertIndex.TabIndex = 7;
            this.lblInsertIndex.Text = "Index";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(207, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.Black;
            this.listView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listView.HideSelection = false;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(512, 95);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(121, 465);
            this.listView.TabIndex = 17;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbSearch.Controls.Add(this.lblSearchValue);
            this.gbSearch.Controls.Add(this.inpSearchValue);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Enabled = false;
            this.gbSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbSearch.Location = new System.Drawing.Point(12, 259);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(358, 75);
            this.gbSearch.TabIndex = 14;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search in array";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(547, 65);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(55, 17);
            this.lblArray.TabIndex = 13;
            this.lblArray.Text = "ARRAY";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(10, 30);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(85, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Array length";
            // 
            // rbSorted
            // 
            this.rbSorted.AutoSize = true;
            this.rbSorted.Location = new System.Drawing.Point(13, 105);
            this.rbSorted.Name = "rbSorted";
            this.rbSorted.Size = new System.Drawing.Size(69, 21);
            this.rbSorted.TabIndex = 4;
            this.rbSorted.Text = "sorted";
            this.rbSorted.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(13, 74);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(77, 21);
            this.rbRandom.TabIndex = 3;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // gbCreate
            // 
            this.gbCreate.BackColor = System.Drawing.Color.Transparent;
            this.gbCreate.Controls.Add(this.lblLength);
            this.gbCreate.Controls.Add(this.rbSorted);
            this.gbCreate.Controls.Add(this.rbRandom);
            this.gbCreate.Controls.Add(this.inpCreateLength);
            this.gbCreate.Controls.Add(this.btnCreateArray);
            this.gbCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCreate.Location = new System.Drawing.Point(12, 95);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(358, 146);
            this.gbCreate.TabIndex = 12;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create array";
            // 
            // inpCreateLength
            // 
            this.inpCreateLength.BackColor = System.Drawing.Color.Black;
            this.inpCreateLength.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inpCreateLength.Location = new System.Drawing.Point(101, 28);
            this.inpCreateLength.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.inpCreateLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpCreateLength.Name = "inpCreateLength";
            this.inpCreateLength.Size = new System.Drawing.Size(72, 22);
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
            this.btnCreateArray.Location = new System.Drawing.Point(207, 30);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(132, 96);
            this.btnCreateArray.TabIndex = 0;
            this.btnCreateArray.Text = "Create array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // gbInsert
            // 
            this.gbInsert.BackColor = System.Drawing.Color.Transparent;
            this.gbInsert.Controls.Add(this.lblInsertIndex);
            this.gbInsert.Controls.Add(this.inpInsertIndex);
            this.gbInsert.Controls.Add(this.lblInsertValue);
            this.gbInsert.Controls.Add(this.inpInsertValue);
            this.gbInsert.Controls.Add(this.btnInsert);
            this.gbInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbInsert.Location = new System.Drawing.Point(12, 358);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(358, 104);
            this.gbInsert.TabIndex = 16;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "Insert in array";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(651, 55);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Arrays and binary search";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 603);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.gbCreate);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task1";
            this.Text = "Task 1";
            ((System.ComponentModel.ISupportInitialize)(this.inpDeleteIndex)).EndInit();
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpInsertIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpInsertValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpSearchValue)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpCreateLength)).EndInit();
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblDeleteIndex;
        private System.Windows.Forms.NumericUpDown inpDeleteIndex;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.NumericUpDown inpInsertIndex;
        private System.Windows.Forms.Label lblInsertValue;
        private System.Windows.Forms.NumericUpDown inpInsertValue;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblSearchValue;
        private System.Windows.Forms.NumericUpDown inpSearchValue;
        private System.Windows.Forms.Label lblInsertIndex;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.RadioButton rbSorted;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.NumericUpDown inpCreateLength;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Label lblTitle;
    }
}