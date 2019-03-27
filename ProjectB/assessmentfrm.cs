using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjectB
{
    public partial class assessmentfrm : Form
    {
        public assessmentfrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScon_TextChanged(object sender, EventArgs e)
        {

        }
        public static int Assess_id;
        bool flag = true;
        Assessment first = new Assessment();
        private void btnSregister_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    first.Title = txtAssesTitle.Text;
                    first.TotalMarks = Convert.ToInt32(txtTotalM.Text);
                    first.TotalWeightage = Convert.ToInt32(txttotal.Text);
                    first.DateCreated = DateTime.Now.Date;
                    string cmd = $"INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage) VALUES('{first.Title}','{first.DateCreated}','{first.TotalMarks}','{first.TotalMarks}')";
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("{0} rows affected", rows));
                }
                else
                {
                    string cmd = string.Format("UPDATE  Assessment SET Title = '{0}',TotalMarks = '{1}',TotalWeightage = '{2}'  WHERE Id= '{3}'", txtAssesTitle.Text, txtTotalM.Text, txttotal.Text, Assess_id);
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("Updated", rows));
                    flag = true;
                }
                SqlDataReader Attendancetoday = databaseconnection.get_instance().Getdata("SELECT * FROM Assessment");
                BindingSource s = new BindingSource();
                s.DataSource = Attendancetoday;
                dataassessment.DataSource = s;

                dataassessment.Columns["assessmentdel"].DisplayIndex = dataassessment.ColumnCount - 1;
                dataassessment.Columns["assessmentupdate"].DisplayIndex = dataassessment.ColumnCount - 1;
                dataassessment.Columns["addcomponent"].DisplayIndex = dataassessment.ColumnCount - 1;

                txtAssesTitle.Text = "";
                txttotal.Text = "";
                txtTotalM.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_Screen i = new Main_Screen();
            this.Hide();
            i.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Assess_id = Convert.ToInt32(this.dataassessment.Rows[e.RowIndex].Cells[3].Value);
            if (dataassessment.Columns[e.ColumnIndex].Name == "assessmentupdate")
            {
                flag = false;
                SqlDataReader Assessment = databaseconnection.get_instance().Getdata("SELECT * FROM Assessment");
                if (Assess_id != 0)
                {
                    while (Assessment.Read())
                    {
                        if (Assessment[0].ToString() == Assess_id.ToString())
                        {
                            txtAssesTitle.Text = Assessment[1].ToString();
                            txtTotalM.Text = Assessment[3].ToString();
                            txttotal.Text = Assessment[4].ToString();
                        }
                    }
                }
            }
            if (dataassessment.Columns[e.ColumnIndex].Name == "assessmentdel")
            {
                SqlDataReader reader = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM AssessmentComponent WHERE AssessmentId='{0}'", Assess_id));
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        string cmd5 = @"delete from AssessmentComponent where AssessmentId=" + Assess_id; ;
                        int y = databaseconnection.get_instance().Executequery(cmd5);

                    }
                }
                string cmd = @"delete from Assessment where Id=" + Assess_id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Assessment and Related Assessment Component(s) Deleted.");
                }
                assessmentfrm_Load(sender, e);
            }
            if (dataassessment.Columns[e.ColumnIndex].Name == "addcomponent")
            {
                AssessmentComonent i = new AssessmentComonent();
                this.Hide();
                i.Show();
            }

        }

        private void assessmentfrm_Load(object sender, EventArgs e)
        {
            string Attendancetoday = string.Format("SELECT * FROM Assessment");

            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listofassessments(Attendancetoday);
            dataassessment.DataSource = s;

            dataassessment.Columns["assessmentdel"].DisplayIndex = dataassessment.ColumnCount - 1;
            dataassessment.Columns["assessmentupdate"].DisplayIndex = dataassessment.ColumnCount - 1;
            dataassessment.Columns["addcomponent"].DisplayIndex = dataassessment.ColumnCount - 1;

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Main_Screen j = new Main_Screen();
            this.Hide();
            j.Show();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }


        private void btnregister_Click(object sender, EventArgs e)
        {
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();

        }

        private void btnAddclo_Click_1(object sender, EventArgs e)
        {

            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void btnStdList_Click_1(object sender, EventArgs e)
        {
            studentlist n = new studentlist();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
                    y = true;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            attendence n = new attendence();
            this.Hide();
            n.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            assessmentfrm s = new assessmentfrm();
            this.Hide();
            s.Show();
        }
    }
}
