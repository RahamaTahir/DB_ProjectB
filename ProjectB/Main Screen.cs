using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //Connection build here
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

        private void button2_Click(object sender, EventArgs e)
        {
            bool y = false;
            SqlDataReader date1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM ClassAttendance"));
            while (date1.Read())
            {
                if (date1[1].ToString() == DateTime.Now.Date.ToString())
                {
                    MessageBox.Show("Today Attendence has been taken!");
                    this.Hide();
                    Main_Screen h = new Main_Screen();
                    h.Show();
                    y =true;
                    break;
                }
            
            }
            if (y == false)
            {

                attendence h = new attendence();
                this.Hide();
                h.Show();

            }

        }

            private void panel6_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button3_Click(object sender, EventArgs e)
        {
            Showattendence k = new Showattendence();
            this.Hide();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            assessmentfrm s = new assessmentfrm();
            this.Hide();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AssessmentComonent j = new AssessmentComonent();
            this.Hide();
            j.Show();
        }
    }
    }
