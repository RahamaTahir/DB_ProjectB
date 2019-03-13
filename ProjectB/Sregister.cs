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

        addstudent student = new addstudent();
        bool n = true;

        private void btnSregister_Click(object sender, EventArgs e)
        {

            try
            {
                int current_status;
                if (!n)
                {
                    student.Firstname = txtSFname.Text;
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
                            string cmd = $"INSERT INTO Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES('{student.Firstname}','{student.Lastname}','{student.Contact}','{student.Email}','{student.Registration_no}','{student.Status}')";
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

        private void SRfrm_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Student";
            if (studentlist.C_Id != 0)
            {
                foreach (addstudent std in databaseconnection.get_instance().Listofstudents(cmd))
                {
                    if (std.Id == studentlist.C_Id)
                    {
                        txtSFname.Text = std.Firstname;
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
    }
}
