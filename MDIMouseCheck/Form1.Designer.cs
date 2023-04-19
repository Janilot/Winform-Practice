
namespace MDIMouseCheck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFileNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFileNewFile2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFileNewFIle3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFileNewFile,
            this.toolStripMenuFileNewFile2,
            this.toolStripMenuFileNewFIle3});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuFile.Text = "파일";
            // 
            // toolStripMenuFileNewFile
            // 
            this.toolStripMenuFileNewFile.Name = "toolStripMenuFileNewFile";
            this.toolStripMenuFileNewFile.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuFileNewFile.Text = "Form2";
            this.toolStripMenuFileNewFile.Click += new System.EventHandler(this.toolStripMenuFileNewFile_Click);
            // 
            // toolStripMenuFileNewFile2
            // 
            this.toolStripMenuFileNewFile2.Name = "toolStripMenuFileNewFile2";
            this.toolStripMenuFileNewFile2.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuFileNewFile2.Text = "Form3";
            this.toolStripMenuFileNewFile2.Click += new System.EventHandler(this.toolStripMenuFileNewFile2_Click);
            // 
            // toolStripMenuFileNewFIle3
            // 
            this.toolStripMenuFileNewFIle3.Name = "toolStripMenuFileNewFIle3";
            this.toolStripMenuFileNewFIle3.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuFileNewFIle3.Text = "Form4";
            this.toolStripMenuFileNewFIle3.Click += new System.EventHandler(this.toolStripMenuFileNewFIle3_Click);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuEdit.Text = "편집";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 705);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFile2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileNewFIle3;
    }
}

