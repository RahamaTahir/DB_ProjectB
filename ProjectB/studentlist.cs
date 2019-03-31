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
    public partial class studentlist : Form
    {
        public studentlist()
        {
            InitializeComponent();
        }
        //stores the current student id
        public static int C_Id;

        /// <summary>
        /// Perform fumction the basis of type of cell clicked
        /// Update to update the student
        /// Delete to delete the student 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            C_Id = Convert.ToInt32(this.studentdata.Rows[e.RowIndex].Cells[3].Value);
            if (studentdata.Columns[e.ColumnIndex].Name == "btn_del")
            {
                string cmd5 = @"delete from StudentResult where StudentId=" + C_Id; ;
                int y = databaseconnection.get_instance().Executequery(cmd5);

                string cmd1 = @"delete from StudentAttendance where StudentId=" + C_Id;
                int j = databaseconnection.get_instance().Executequery(cmd1);
                string cmd = @"delete from Student where Id=" + C_Id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Deleted.");
                    studentlist_Load(sender, e);
                }
            }
           
            if (studentdata.Columns[e.ColumnIndex].Name== "edit")
            {   
                SRfrm h = new SRfrm();
                this.Hide();
                h.Show();
            }
        }

        /// <summary>
        /// Load the student list in datagrid view obtain from listofstudent function from database connection class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentlist_Load(object sender, EventArgs e)
        {
            
            string cmd = "SELECT * FROM Student";
            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listofstudents(cmd);
            studentdata.DataSource = s;

            //here I covwet the status from 5,6 to Active, InActive
            foreach (DataGridViewRow dgvRow in studentdata.Rows)
            {
                if (dgvRow.Cells[4].FormattedValue.ToString() == "5")
                // Here I'd update the row (at this point I already have the row index)
                {
                    dgvRow.Cells[0].Value = "Active" ;
                }
                if (dgvRow.Cells[4].FormattedValue.ToString() == "6")
                {
                    dgvRow.Cells[0].Value ="InActive";
                }
                
            }
            //studentdata.Columns.Add(btn);
            studentdata.Columns.RemoveAt(4);
            studentdata.Columns["txt_status"].DisplayIndex = studentdata.ColumnCount - 1;
            studentdata.Columns["edit"].DisplayIndex = studentdata.ColumnCount - 1;
            studentdata.Columns["btn_del"].DisplayIndex = studentdata.ColumnCount - 1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Function load other forms on the click of buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnregister_Click(object sender, EventArgs e)
        {
            SRfrm n = new SRfrm();
            this.Hide();
            n.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            //opens the registereed Student list
            Clos k = new Clos();
            this.Hide();
            k.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_Screen n = new Main_Screen();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        /// <summary>
        /// Openss the attendance form if attendance had not takeen on that day
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

        private void button5_Click(object sender, EventArgs e)
        {
            //show the attendance in new form for any day
            Showattendence y = new Showattendence();
            this.Hide();
            y.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Opens the assessment manage form
            assessmentfrm l = new assessmentfrm();
            this.Hide();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
