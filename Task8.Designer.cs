
namespace Algorithms
{
    partial class Task8
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
            this.components = new System.ComponentModel.Container();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblAnswer = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblArrow = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmsInput.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInput.ContextMenuStrip = this.cmsInput;
            this.tbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbInput.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(0, 0);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(336, 46);
            this.tbInput.TabIndex = 35;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 73);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Roman-arabic converter";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsItemUndo
            // 
            this.cmsItemUndo.Name = "cmsItemUndo";
            this.cmsItemUndo.Size = new System.Drawing.Size(140, 24);
            this.cmsItemUndo.Text = "Undo";
            // 
            // cmsSeparator1
            // 
            this.cmsSeparator1.Name = "cmsSeparator1";
            this.cmsSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // cmsItemCut
            // 
            this.cmsItemCut.Name = "cmsItemCut";
            this.cmsItemCut.Size = new System.Drawing.Size(140, 24);
            this.cmsItemCut.Text = "Cut";
            // 
            // cmsItemCopy
            // 
            this.cmsItemCopy.Name = "cmsItemCopy";
            this.cmsItemCopy.Size = new System.Drawing.Size(140, 24);
            this.cmsItemCopy.Text = "Copy";
            // 
            // cmsItemPaste
            // 
            this.cmsItemPaste.Name = "cmsItemPaste";
            this.cmsItemPaste.Size = new System.Drawing.Size(140, 24);
            this.cmsItemPaste.Text = "Paste";
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.Size = new System.Drawing.Size(140, 24);
            this.cmsItemDelete.Text = "Delete";
            // 
            // cmsSeparator2
            // 
            this.cmsSeparator2.Name = "cmsSeparator2";
            this.cmsSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // cmsItemSelectAll
            // 
            this.cmsItemSelectAll.Name = "cmsItemSelectAll";
            this.cmsItemSelectAll.Size = new System.Drawing.Size(140, 24);
            this.cmsItemSelectAll.Text = "Select All";
            // 
            // cmsInput
            // 
            this.cmsInput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemUndo,
            this.cmsSeparator1,
            this.cmsItemCut,
            this.cmsItemCopy,
            this.cmsItemPaste,
            this.cmsItemDelete,
            this.cmsSeparator2,
            this.cmsItemSelectAll});
            this.cmsInput.Name = "cmsInput";
            this.cmsInput.Size = new System.Drawing.Size(141, 160);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.Location = new System.Drawing.Point(0, 192);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(336, 40);
            this.lblAnswer.TabIndex = 36;
            this.lblAnswer.Text = "???";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel.Controls.Add(this.lblInfo);
            this.panel.Controls.Add(this.lblArrow);
            this.panel.Controls.Add(this.lblAnswer);
            this.panel.Controls.Add(this.tbInput);
            this.panel.Location = new System.Drawing.Point(230, 76);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(336, 232);
            this.panel.TabIndex = 39;
            // 
            // lblArrow
            // 
            this.lblArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArrow.Location = new System.Drawing.Point(0, 46);
            this.lblArrow.Margin = new System.Windows.Forms.Padding(0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(336, 146);
            this.lblArrow.TabIndex = 37;
            this.lblArrow.Text = "↓";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(0, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(336, 30);
            this.lblInfo.TabIndex = 38;
            this.lblInfo.Text = "Unrecognized numerals";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Task8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Task8";
            this.Text = "Task_8";
            this.cmsInput.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cmsInput;
        private System.Windows.Forms.ToolStripMenuItem cmsItemUndo;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsItemCut;
        private System.Windows.Forms.ToolStripMenuItem cmsItemCopy;
        private System.Windows.Forms.ToolStripMenuItem cmsItemPaste;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripSeparator cmsSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSelectAll;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Label lblInfo;
    }
}