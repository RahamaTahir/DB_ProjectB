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
    public partial class rubriclevel : Form
    {
        public rubriclevel()
        {
            InitializeComponent();
        }

        //create object of LevelRubrics type to access it to any where
        levelrubrics level = new levelrubrics();

        //flag to handle edit or update of level of rubrics
        bool flag = true;

        //Stores the rubruc level ID
        public static int L_id;

        /// <summary>
        /// This function add and update the rubric level according to flag value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrubricadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (flag)
                {
                    level.Details = txtleveldetails.Text;
                    level.MeasurementLevel = Convert.ToInt32(txtML.Text);
                    level.RubricId = addrubric.id;
                    string cmd3 = $"INSERT INTO RubricLevel(RubricId,Details,MeasurementLevel) VALUES('{level.RubricId}','{level.Details}','{level.MeasurementLevel}')";
                    int rows = databaseconnection.get_instance().Executequery(cmd3);
                    MessageBox.Show(String.Format("{0} rows affected", rows));
                }
                else
                {
                    string cmd2 = string.Format("UPDATE  RubricLevel SET Details = '{0}', MeasurementLevel = '{1}' WHERE Id= '{2}'", txtleveldetails.Text, Convert.ToInt32(txtML.Text), L_id);
                    int rows = databaseconnection.get_instance().Executequery(cmd2);
                    MessageBox.Show(String.Format("Updated", rows));
                    flag = true;
                }

                //Update the data grid contents
                string cmd = string.Format("SELECT * FROM RubricLevel Where RubricId={0}", addrubric.id);
                BindingSource s = new BindingSource();
                s.DataSource = databaseconnection.get_instance().Listoflevels(cmd);
                datalevel.DataSource = s;
                datalevel.Columns["btn_updatelevel"].DisplayIndex = datalevel.ColumnCount - 1;
                datalevel.Columns["btn_levelDel"].DisplayIndex = datalevel.ColumnCount - 1;

                txtleveldetails.Text = "";
                txtML.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Any button in the datagrid view click it do the coresponding actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datalevel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            L_id = Convert.ToInt32(this.datalevel.Rows[e.RowIndex].Cells[2].Value);

            //On the click of update button
            if (datalevel.Columns[e.ColumnIndex].Name == "btn_updatelevel")
            {
                flag = false;
                string query = "SELECT * FROM RubricLevel";
                if (L_id != 0)
                {
                    foreach (levelrubrics std in databaseconnection.get_instance().Listoflevels(query))
                    {
                        if (std.Id == L_id)
                        {
                            txtleveldetails.Text = std.Details;
                            txtML.Text = std.MeasurementLevel.ToString();
                        }
                    }
                }
            }

            //On the click of delete button
            if (datalevel.Columns[e.ColumnIndex].Name == "btn_levelDel")
            {
                string cmd = @"delete from RubricLevel where Id=" + L_id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Deleted.");
                    string cmd1 = string.Format("SELECT * FROM RubricLevel Where RubricId={0}", addrubric.id);
                    BindingSource s = new BindingSource();
                    s.DataSource = databaseconnection.get_instance().Listoflevels(cmd1);
                    datalevel.DataSource = s;
                    datalevel.Columns["btn_updatelevel"].DisplayIndex = datalevel.ColumnCount - 1;
                    datalevel.Columns["btn_levelDel"].DisplayIndex = datalevel.ColumnCount - 1;

                }

            }


        }

        /// <summary>
        /// when form load iit update the datagrid view values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rubriclevel_Load(object sender, EventArgs e)
        {
            SqlDataReader read1 = databaseconnection.get_instance().Getdata("SELECT * FROM Rubric");
            while (read1.Read())
            {

                if (addrubric.id == Convert.ToInt32(read1[0]))
                {
                    levenamelbl.Text = read1[1].ToString();
                }
            }
            string cmd = string.Format("SELECT * FROM RubricLevel Where RubricId={0}", addrubric.id);
            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listoflevels(cmd);
            datalevel.DataSource = s;
            datalevel.Columns["btn_updatelevel"].DisplayIndex = datalevel.ColumnCount - 1;
            datalevel.Columns["btn_levelDel"].DisplayIndex = datalevel.ColumnCount - 1;

        }

        /// <summary>
        /// Buttons to open other forms
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
            SRfrm i = new SRfrm();
            this.Hide();
            i.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist h = new studentlist();
            this.Hide();
            h.Show();
        }


        private void btnAddclo_Click_1(object sender, EventArgs e)
        {

            Clos h = new Clos();
            this.Hide();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clos h = new Clos();
            this.Hide();
            h.Show();

        }
    }
}