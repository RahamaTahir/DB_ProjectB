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
            databaseconnection.get_instance().connectionstring = "Data Source=HAIER-PC;Initial Catalog=ProjectB;Integrated Security=True";
            try
            {
                var con = databaseconnection.get_instance().Getconnection();
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }
    }
}
