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
            //opens the student registration form
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            //opens the registereed Student list
            studentlist n = new studentlist();
            this.Hide();
            n.Show();
        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {

        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            //opens the manage Clo form
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //opens the manage Clo form
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }

        /// <summary>
        /// Opens the attendance form if attendance has taken for that date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            bool y = false;
            SqlDataReader date1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM ClassAttendance"));
            if (date1 != null)
            {
                while (date1.Read())
                {
                    if (date1[1].ToString() == DateTime.Now.Date.ToString())
                    {
                        MessageBox.Show("Today Attendence has been taken!");
                        this.Hide();
                        Main_Screen h = new Main_Screen();
                        h.Show();
                        y = true;
                        break;
                    }

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
            //show the attendance in new form for any day
            Showattendence k = new Showattendence();
            this.Hide();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Opens the assessment manage form
            assessmentfrm s = new assessmentfrm();
            this.Hide();
            s.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //opens the result calculation form of students
            resultStudentForm j = new resultStudentForm();
            this.Hide();
            j.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Generate Reports form open
            pdfreport o = new pdfreport();
            this.Hide();
            o.Show();

        }
    }
    }
