using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Main_Screen : Form
    {
        public Main_Screen()
        {
            InitializeComponent();
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist n = new studentlist();
            this.Hide();
            n.Show();
        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
