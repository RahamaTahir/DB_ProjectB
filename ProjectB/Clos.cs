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
    public partial class Clos : Form
    {
        public Clos()
        {
            InitializeComponent();
        }

        //new Clo type of object is created to access it to the whole form code
        Clo new_clo = new Clo();

        //Flag created to manage the edit and create role
        bool flag = true;
        
        //this maintain the clo id 
        public static int Clo_Id;

        /// <summary>
        /// This function add the clo and update the clo by using flag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloadd_Click(object sender, EventArgs e)
        {
            try
            {
                if(flag)
                {
                    new_clo.Name = txtCloname.Text;
                    new_clo.Datecreated = DateTime.Now.Date;
                    new_clo.Dateupdated = DateTime.Now.Date;
                    string query = $"INSERT INTO Clo(Name,DateCreated,DateUpdated) VALUES('{new_clo.Name}','{new_clo.Datecreated}','{new_clo.Dateupdated}')";
                    int rows = databaseconnection.get_instance().Executequery(query);
                    MessageBox.Show(String.Format("{0} rows affected", rows));

                }
                else
                {
                    string cmd = string.Format("UPDATE  Clo SET Name = '{0}',DateUpdated = '{1}'  WHERE Id= '{2}'", txtCloname.Text, DateTime.Now.Date,Clo_Id);
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("Updated", rows));
                    flag = true;
                }
                string cmd1 = "SELECT * FROM Clo";
                BindingSource s = new BindingSource();
                s.DataSource = databaseconnection.get_instance().ListofClo(cmd1);
                clodata.DataSource = s;
                clodata.Columns["Clo_edit"].DisplayIndex = clodata.ColumnCount - 1;
                clodata.Columns["btn_del1"].DisplayIndex = clodata.ColumnCount - 1;
                clodata.Columns["btn_addRubric"].DisplayIndex = clodata.ColumnCount - 1;
                txtCloname.Text = "";
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This function update,delete and manage Rubrics accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clodata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clo_Id = Convert.ToInt32(this.clodata.Rows[e.RowIndex].Cells[3].Value);
            if (clodata.Columns[e.ColumnIndex].Name == "Clo_edit")
            {
                flag = false;
                string query = "SELECT * FROM Clo";
                if (Clo_Id != 0)
                {
                    foreach (Clo std in databaseconnection.get_instance().ListofClo(query))
                    {
                        if (std.Id == Clo_Id)
                        {
                            txtCloname.Text = std.Name;
                        }
                    }
                }
            }
            
            if (clodata.Columns[e.ColumnIndex].Name == "btn_del1")
            {
                int temp; 
                SqlDataReader reader1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM Rubric Where CloId = '{0}'",Clo_Id));
                if (reader1 != null)
                {
                    while (reader1.Read())
                    {
                        temp = Convert.ToInt32(reader1.GetValue(0));
                        SqlDataReader reader2 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM RubricLevel Where RubricId = '{0}'", temp));
                        if (reader2 != null)
                        {
                            while (reader2.Read())
                            {
                                string cmd5 = @"delete from RubricLevel where RubricId=" + temp; ;
                                int y = databaseconnection.get_instance().Executequery(cmd5);
                            }
                        }
                        string cmd2 = @"delete from Rubric where Id=" + temp; ;
                        int s = databaseconnection.get_instance().Executequery(cmd2);

                    }
                }
                
                string cmd = @"delete from Clo where Id=" + Clo_Id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Clo and Related Rubric(s) and Rubric Level(s) Deleted.");
                    string cmd1 = "SELECT * FROM Clo";
                    BindingSource j = new BindingSource();
                    j.DataSource = databaseconnection.get_instance().ListofClo(cmd1);
                    clodata.DataSource = j;
                    clodata.Columns["Clo_edit"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_del1"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_addRubric"].DisplayIndex = clodata.ColumnCount - 1;

                }
            }
            if (clodata.Columns[e.ColumnIndex].Name == "btn_addRubric")
            {
                addrubric r = new addrubric();
                
                this.Hide();
                r.Show();
            }
        }

        /// <summary>
        /// This data the datagrid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowclo_Click(object sender, EventArgs e)
        {

            string cmd = "SELECT * FROM Clo";
            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().ListofClo(cmd);
            clodata.DataSource = s;
            clodata.Columns["Clo_edit"].DisplayIndex = clodata.ColumnCount - 1;
            clodata.Columns["btn_del1"].DisplayIndex = clodata.ColumnCount - 1;
            clodata.Columns["btn_addRubric"].DisplayIndex = clodata.ColumnCount - 1;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCloname_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Function to calll other screens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_Screen g = new Main_Screen();
            this.Hide();
            g.Show();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            SRfrm n = new SRfrm();
            this.Hide();
            n.Show();
        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
           
            this.Show();
         
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist k = new studentlist();
            this.Hide();
            k.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
    }
}
