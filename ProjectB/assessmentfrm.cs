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
        //Id to keep the id of assessment to access it anywhere
        public static int Assess_id;

        //flag to handle edit and save functionality
        bool flag = true;

        //Object to save in database
        Assessment first = new Assessment();

        /// <summary>
        /// It edit or save the assessments 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSregister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAssesTitle.Text != "")
                {
                    if (flag)
                    {
                        first.Title = txtAssesTitle.Text;
                        first.TotalMarks = Convert.ToInt32(txtTotalM.Text);
                        first.TotalWeightage = Convert.ToInt32(txttotal.Text);
                        first.DateCreated = DateTime.Now.Date;
                        string cmd = $"INSERT INTO Assessment(Title,DateCreated,TotalMarks,TotalWeightage) VALUES('{first.Title}','{first.DateCreated}','{first.TotalMarks}','{first.TotalWeightage}')";
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
                else
                {
                    MessageBox.Show("Title should not be empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        /// <summary>
        /// Edit or delete or opens the assessment component form according to the cell Name that pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Assess_id = Convert.ToInt32(this.dataassessment.Rows[e.RowIndex].Cells[3].Value);
            //edit here
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

            //Delete the Assessment component and assessment
            if (dataassessment.Columns[e.ColumnIndex].Name == "assessmentdel")
            {
                SqlDataReader reader = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM AssessmentComponent WHERE AssessmentId='{0}'", Assess_id));
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        //delete the assessment component here that have the save assessmeent ID
                        string cmd5 = @"delete from AssessmentComponent where AssessmentId=" + Assess_id; ;
                        int y = databaseconnection.get_instance().Executequery(cmd5);

                    }
                }
                //delete the assessment that have the assessment ID
                string cmd = @"delete from Assessment where Id=" + Assess_id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Assessment and Related Assessment Component(s) Deleted.");
                }
                assessmentfrm_Load(sender, e);
            }
            //opens the assessment componenet manage page
            if (dataassessment.Columns[e.ColumnIndex].Name == "addcomponent")
            {
                AssessmentComonent i = new AssessmentComonent();
                this.Hide();
                i.Show();
            }

        }

        /// <summary>
        /// loads the data of assessment in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //opens the main screen
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

        

        private void btnregister_Click(object sender, EventArgs e)
        {
            //opens the Student registration form
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();

        }

        private void btnAddclo_Click_1(object sender, EventArgs e)
        {
            //opens the Clo manage page
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void btnStdList_Click_1(object sender, EventArgs e)
        {
            //opens the all student list
            studentlist n = new studentlist();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens the Clo manage page
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        /// <summary>
        /// Opens the attendance form if attendance has taken for that date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            //Opens the attendance list form
            attendence n = new attendence();
            this.Hide();
            n.Show();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //open the assessment form
            assessmentfrm s = new assessmentfrm();
            this.Hide();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //opens the result calculation page of students
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
