using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIMouseCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

  

        private void toolStripMenuFileNewFile_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuFileNewFile2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuFileNewFIle3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.MdiParent = this;
            form.Show();
        }
    }
}
