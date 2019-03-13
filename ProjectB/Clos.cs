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

        Clo new_clo = new Clo();
        bool flag = true;
        public static int Clo_Id;

        private void btnCloadd_Click(object sender, EventArgs e)
        {
            try
            {
                if(flag)
                {
                    new_clo.Name = txtCloname.Text;
                    new_clo.Datecreated = DateTime.Now.Date;
                    new_clo.Dateupdated = DateTime.Now.Date.Date;
                    string query = $"INSERT INTO Clo(Name,DateCreated,DateUpdated) VALUES('{new_clo.Name}','{new_clo.Datecreated}','{new_clo.Dateupdated}')";
                    int rows = databaseconnection.get_instance().Executequery(query);
                    MessageBox.Show(String.Format("{0} rows affected", rows));

                }
                else
                {
                    string cmd = string.Format("UPDATE  Clo SET Name = '{0}',DateUpdated = '{1}'  WHERE Id= '{2}'", txtCloname.Text, DateTime.Now.Date,Clo_Id);
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("Updated", rows));
                    string cmd1 = "SELECT * FROM Clo";
                    BindingSource s = new BindingSource();
                    s.DataSource = databaseconnection.get_instance().ListofClo(cmd1);
                    clodata.DataSource = s;
                    clodata.Columns["Clo_edit"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_del1"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_addRubric"].DisplayIndex = clodata.ColumnCount - 1;

                }
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
        }

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

                string cmd = @"delete from Clo where Id=" + Clo_Id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Deleted.");
                    string cmd1 = "SELECT * FROM Clo";
                    BindingSource s = new BindingSource();
                    s.DataSource = databaseconnection.get_instance().ListofClo(cmd1);
                    clodata.DataSource = s;
                    clodata.Columns["Clo_edit"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_del1"].DisplayIndex = clodata.ColumnCount - 1;
                    clodata.Columns["btn_addRubric"].DisplayIndex = clodata.ColumnCount - 1;

                }
            }
        }

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
    }
}
