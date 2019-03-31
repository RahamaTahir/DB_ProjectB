using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectB
{
    public partial class Showattendence : Form
    {
        public Showattendence()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void datarubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtrubricdetails_TextChanged(object sender, EventArgs e)
        {

        }
        //flag to manage save or edit functions
        bool h = true;
        //contain id to access it anywhere
        static private int id;

        /// <summary>
        /// Show the list of active students with a comboboxin end of every row in datagridview 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrubricadd_Click(object sender, EventArgs e)
        {
            SqlDataReader Attendence = databaseconnection.get_instance().Getdata("SELECT * FROM ClassAttendance");

            while (Attendence.Read())
            {
                if (dateTimePicker1.Value.Date.ToString() == Attendence[1].ToString())
                {
                    id = Convert.ToInt32(Attendence[0]);
                    SqlDataReader Attendancetoday = databaseconnection.get_instance().Getdata(string.Format("SELECT FirstName,LastName,RegistrationNumber,AttendanceStatus,AttendanceId FROM StudentAttendance S JOIN Student D ON S.StudentId = D.Id WHERE S.AttendanceId='{0}'",id));
                  
                    BindingSource s = new BindingSource();
                    s.DataSource = Attendancetoday;
                    dataattendance.DataSource = s;

                    int rowIndex = 0;
                    foreach (DataGridViewRow dgvRow in dataattendance.Rows)
                    {
                        if (dgvRow.Cells[4].FormattedValue.ToString() == "1")
                        // Here I'd update the row (at this point I already have the row index)
                        {
                            dgvRow.Cells[0].Value = "Present";
                        }
                        if (dgvRow.Cells[4].FormattedValue.ToString() == "2")
                        {
                            dgvRow.Cells[0].Value = "Absent";
                        }
                        if (dgvRow.Cells[4].FormattedValue.ToString() == "3")
                        {
                            dgvRow.Cells[0].Value = "Leave";
                        }
                        if (dgvRow.Cells[4].FormattedValue.ToString() == "4")
                        {
                            dgvRow.Cells[0].Value = "Late";
                        }
                        rowIndex++;


                    }

                    h = false;
                    dataattendance.Columns.RemoveAt(4);
                    //dataattendance.Columns.RemoveAt(5);
                }
                
                
            }
            if(h==true)
            {
                MessageBox.Show("Attendance was not taken at that day");
                
            }
            else
            {
                h = true;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //show the attendance in new form for any day
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Opens the assessment manage form
            assessmentfrm l = new assessmentfrm();
            this.Hide();
            l.Show();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            //opens the student registration form
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ///opens the student resukt calculation form 
            resultStudentForm j = new resultStudentForm();
            this.Hide();
            j.Show();
        }

        private void btnAddclo_Click_1(object sender, EventArgs e)
        {
            //opens the registereed Student list
            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        private void btnStdList_Click_1(object sender, EventArgs e)
        {
            //opens the registered student list
            studentlist n = new studentlist();
            this.Hide();
            n.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opens the clo manage page
            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        /// <summary>
        /// open the attendance form if attendance has not taken for that day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            //opens the main screen
            Main_Screen i = new Main_Screen();
            this.Hide();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //opens the result calculation form of students
            resultStudentForm j = new resultStudentForm();
            this.Hide();
            j.Show();
        }

        private void Showattendence_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Generate Reports form open
            pdfreport o = new pdfreport();
            this.Hide();
            o.Show();

        }
    }
}
