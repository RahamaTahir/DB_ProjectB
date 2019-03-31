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
    public partial class attendence : Form
    {
        public attendence()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //open the student registration form
            SRfrm i = new SRfrm();
            this.Hide();
            i.Show();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //reloads the main screen
            Main_Screen g = new Main_Screen();
            this.Hide();
            g.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            //open the registered student list
            studentlist h = new studentlist();
            this.Hide();
            h.Show();

        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            //open the clo manage page
            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the clo manage page
            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Opens the attendance form if attendance has taken for that date
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// loads the data of active students in datagrid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void attendence_Load(object sender, EventArgs e)
        {
            try
            {
                string cmd = "SELECT Id,FirstName,LastName,RegistrationNumber FROM Student Where Status='5'";

                BindingSource s = new BindingSource();
                s.DataSource = databaseconnection.get_instance().Getdata(cmd);
                attendencedata.DataSource = s;
                attendencedata.Columns["present"].DisplayIndex = attendencedata.ColumnCount - 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        Showattendence k = new Showattendence();
        /// <summary>
        /// saves the attendance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsubmit_Click(object sender, EventArgs e)
        {

            try
            {
                string cmd = $"INSERT INTO ClassAttendance(AttendanceDate) VALUES('{DateTime.Now.Date}')";
                int rows = databaseconnection.get_instance().Executequery(cmd);
                
                for (int x = 0; x < attendencedata.Rows.Count ; x++)
                {
                    SqlDataReader reader1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM Student"));

                    while (reader1.Read())
                    {
                        //for combobox column
                        string cmbvalue = attendencedata.Rows[x].Cells[0].Value.ToString();
                        string cmbvalue1 = attendencedata.Rows[x].Cells[1].Value.ToString();
                        if (reader1[0].ToString() == cmbvalue1)
                        {
                            SqlDataReader date = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM ClassAttendance"));
                            while (date.Read())
                            {

                                SqlDataReader status = databaseconnection.get_instance().Getdata("SELECT * FROM Lookup");
                                if (date[1].ToString() == DateTime.Now.Date.ToString())
                                {
                                    while (status.Read())
                                    {
                                        if (status[1].ToString() == cmbvalue)
                                        {
                                            studentattendence student = new studentattendence();
                                            student.AttendenceId = Convert.ToInt32(date[0]);
                                            student.AttendenceStatus = Convert.ToInt32(status[0]);
                                            student.StudentId = Convert.ToInt32(reader1[0]);
                                            string cmd1 = $"INSERT INTO StudentAttendance(AttendanceId,StudentId,AttendanceStatus) VALUES('{student.AttendenceId}','{student.StudentId}','{student.AttendenceStatus}')";
                                            int rows1 = databaseconnection.get_instance().Executequery(cmd1);


                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                MessageBox.Show(String.Format("{0} rows affected", rows));
                this.Hide();
                k.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //opens the show attendance page
            this.Hide();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //opens the assessment manage form
            assessmentfrm k = new assessmentfrm();
            this.Hide();
            k.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ///opens the student result calculation form
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
