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
    public partial class addrubric : Form
    {
        public addrubric()
        {
            InitializeComponent();
        }

        newrubric rubric = new newrubric();
        bool flag = true;
        public static int id;
        private void btnCloadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    rubric.Details = txtrubricdetails.Text;
                    rubric.Cloid = Clos.Clo_Id;
                    string cmd = $"INSERT INTO Rubric(Details,Cloid) VALUES('{rubric.Details}','{rubric.Cloid}')";
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("{0} rows affected", rows));

                    
                }
                else
                {
                    string cmd = string.Format("UPDATE  Rubric SET Details = '{0}' WHERE Id= '{1}'", txtrubricdetails.Text, id);
                    int rows = databaseconnection.get_instance().Executequery(cmd);
                    MessageBox.Show(String.Format("Updated", rows));
                    flag = true;
                }
                //update datagrid view
                string cmd1 = string.Format("SELECT * FROM Rubric Where CloId={0}", Clos.Clo_Id);

                BindingSource s = new BindingSource();
                s.DataSource = databaseconnection.get_instance().Listofrubrics(cmd1);
                datarubric.DataSource = s;
                datarubric.Columns["btn_RubricDel"].DisplayIndex = datarubric.ColumnCount - 1;
                datarubric.Columns["btn_updaterubric"].DisplayIndex = datarubric.ColumnCount - 1;
                datarubric.Columns["btn_rubriclevel"].DisplayIndex = datarubric.ColumnCount - 1;
                txtrubricdetails.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void addrubric_Load(object sender, EventArgs e)
        {
            SqlDataReader read1 = databaseconnection.get_instance().Getdata("SELECT * FROM Clo");
            while(read1.Read())
            {

                if(Clos.Clo_Id == Convert.ToInt32(read1[0]))
                {
                    clonamelbl.Text = read1[1].ToString();
                }
            }
            string cmd = string.Format("SELECT * FROM Rubric Where CloId={0}", Clos.Clo_Id);
            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listofrubrics(cmd);
            datarubric.DataSource = s;
            datarubric.Columns["btn_RubricDel"].DisplayIndex = datarubric.ColumnCount - 1;
            datarubric.Columns["btn_updaterubric"].DisplayIndex = datarubric.ColumnCount - 1;
            datarubric.Columns["btn_rubriclevel"].DisplayIndex = datarubric.ColumnCount - 1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(this.datarubric.Rows[e.RowIndex].Cells[3].Value);
            if (datarubric.Columns[e.ColumnIndex].Name == "btn_updaterubric")
            {
                flag = false;
                string query = "SELECT * FROM Rubric";
                if (id != 0)
                {
                    foreach (Rubricaddclass std in databaseconnection.get_instance().Listofrubrics(query))
                    {
                        if (std.Id == id)
                        {
                            txtrubricdetails.Text = std.Details;
                        }
                    }
                }
            }
            if (datarubric.Columns[e.ColumnIndex].Name == "btn_RubricDel")
            {
                SqlDataReader reader1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM RubricLevel Where RubricId = '{0}'",id ));
                if (reader1 != null)
                {
                    while (reader1.Read())
                    {
                        string cmd2 = @"delete from RubricLevel where RubricId=" + id; ;
                        int s = databaseconnection.get_instance().Executequery(cmd2);

                    }
                }
                string cmd = @"delete from Rubric where Id=" + id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Rubric and its level(s) Deleted.");
                    string cmd1 = string.Format("SELECT * FROM Rubric Where CloId={0}", Clos.Clo_Id);

                    BindingSource s = new BindingSource();
                    s.DataSource = databaseconnection.get_instance().Listofrubrics(cmd1);
                    datarubric.DataSource = s;
                    datarubric.Columns["btn_RubricDel"].DisplayIndex = datarubric.ColumnCount - 1;
                    datarubric.Columns["btn_updaterubric"].DisplayIndex = datarubric.ColumnCount - 1;
                    datarubric.Columns["btn_rubriclevel"].DisplayIndex = datarubric.ColumnCount - 1;

                }

            }
            if (datarubric.Columns[e.ColumnIndex].Name == "btn_rubriclevel")
            {
                rubriclevel d = new rubriclevel();
                this.Hide();
                d.Show();
            }
        }
        
        private void btnregister_Click(object sender, EventArgs e)
        {
            SRfrm i = new SRfrm();
            this.Hide();
            i.Show();
        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist h = new studentlist();
            this.Hide();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Screen g = new Main_Screen();
            this.Hide();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clos h = new Clos();
            this.Hide();
            h.Show();
        
    }
    }
}
