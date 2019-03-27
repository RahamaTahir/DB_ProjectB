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

        static private int id;
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
                    dataattendance.Columns.RemoveAt(4);
                    //dataattendance.Columns.RemoveAt(5);
                }
                
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Showattendence y = new Showattendence();
            this.Hide();
            y.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assessmentfrm l = new assessmentfrm();
            this.Hide();
            l.Show();
        }
    }
}
