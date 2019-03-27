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
    public partial class SRfrm : Form
    {
        public SRfrm()
        {
            InitializeComponent();
            
        }
        
        //Create the student type object to access it any where 
        addstudent student = new addstudent();

        //to handle the edit and create function
        bool n = true;

        /// <summary>
        /// It create and update the student according to bool flag value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSregister_Click_1(object sender, EventArgs e)
        {

            try
            {
                int current_status;
                if (!n)
                {
                    student.FirstName = txtSFname.Text;
                    student.Lastname = txtSLname.Text;
                    student.Registration_no = txtSregno.Text;
                    student.Email= txtSEmail.Text;
                    student.Contact = txtScon.Text;
                    SqlDataReader status= databaseconnection.get_instance().Getdata("SELECT * FROM Lookup") ;
                    while(status.Read())
                    {
                        if(status[1].ToString()==comboSstatus.Text)
                        {
                            current_status = Convert.ToInt32(status[0]);
                            student.Status = current_status;
                            string cmd = $"INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES('{student.FirstName}','{student.Lastname}','{student.Contact}','{student.Email}','{student.Registration_no}','{student.Status}')";
                            int rows = databaseconnection.get_instance().Executequery(cmd);
                            MessageBox.Show(String.Format("{0} rows affected", rows));
                            
                        }
                    }
                   
                    studentlist s = new studentlist();
                    this.Hide();
                    s.Show();
                }
                else
                {
                    SqlDataReader status = databaseconnection.get_instance().Getdata("SELECT * FROM Lookup");
                    while (status.Read())
                    {
                        if (status[1].ToString() == comboSstatus.Text)
                        {
                            int ys = studentlist.C_Id;
                            current_status = Convert.ToInt32(status[0]);
                            student.Status = current_status;
                            string cmd = string.Format("UPDATE  Student SET FirstName = '{0}', LastName ='{1}',Contact = '{2}',Email ='{3}',RegistrationNumber ='{4}',Status ='{5}'  WHERE Id= '{6}'", txtSFname.Text, txtSLname.Text, txtScon.Text, txtSEmail.Text, txtSregno.Text, current_status, ys);
                            int rows = databaseconnection.get_instance().Executequery(cmd);
                            MessageBox.Show(String.Format("{0} rows affected", rows));
                            studentlist s = new studentlist();
                            this.Hide();
                            s.Show();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// It automatically set the text boxes Text if it opens to update the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SRfrm_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Student";
            if (studentlist.C_Id != 0)
            {
                foreach (addstudent std in databaseconnection.get_instance().Listofstudents(cmd))
                {
                    if (std.Id == studentlist.C_Id)
                    {
                        txtSFname.Text = std.FirstName;
                        txtSLname.Text = std.Lastname;
                        txtSEmail.Text = std.Email;
                        txtSregno.Text = std.Registration_no;
                        txtScon.Text = std.Contact;
                        if (std.Status == 5)
                        {
                            comboSstatus.Text = "Active";
                        }
                        else
                        {
                            comboSstatus.Text = "InActive";
                        }
                    }
                }
            }

            else
            {
                n = false;
            }
        }
        
        /// <summary>
        /// button click functions to open other forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            Clos n = new Clos();
            this.Hide();
            n.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist j = new studentlist();
            this.Hide();
            j.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_Screen g = new Main_Screen();
            this.Hide();
            g.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendence h = new attendence();
            this.Hide();
            h.Show();

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
