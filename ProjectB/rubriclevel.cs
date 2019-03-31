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

                int rowIndex = 0;
                foreach (DataGridViewRow dgvRow in datalevel.Rows)
                {
                    if (dgvRow.Cells[5].FormattedValue.ToString() == "1")
                    // Here I'd update the row (at this point I already have the row index)
                    {
                        dgvRow.Cells[0].Value = "Unsatisfactory";
                    }
                    if (dgvRow.Cells[5].FormattedValue.ToString() == "2")
                    {
                        dgvRow.Cells[0].Value = "Fair";
                    }
                    if (dgvRow.Cells[5].FormattedValue.ToString() == "3")
                    {
                        dgvRow.Cells[0].Value = "Good";
                    }
                    if (dgvRow.Cells[5].FormattedValue.ToString() == "4")
                    {
                        dgvRow.Cells[0].Value = "Exceptional";
                    }
                    rowIndex++;

                }
                datalevel.Columns.RemoveAt(5);
                datalevel.Columns["degree"].DisplayIndex = datalevel.ColumnCount - 2;

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
            L_id = Convert.ToInt32(this.datalevel.Rows[e.RowIndex].Cells[3].Value);

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


                    int rowIndex = 0;
                    foreach (DataGridViewRow dgvRow in datalevel.Rows)
                    {
                        if (dgvRow.Cells[5].FormattedValue.ToString() == "1")
                        // Here I'd update the row (at this point I already have the row index)
                        {
                            dgvRow.Cells[0].Value = "Unsatisfactory";
                        }
                        if (dgvRow.Cells[5].FormattedValue.ToString() == "2")
                        {
                            dgvRow.Cells[0].Value = "Fair";
                        }
                        if (dgvRow.Cells[5].FormattedValue.ToString() == "3")
                        {
                            dgvRow.Cells[0].Value = "Good";
                        }
                        if (dgvRow.Cells[5].FormattedValue.ToString() == "4")
                        {
                            dgvRow.Cells[0].Value = "Exceptional";
                        }
                        rowIndex++;
                    }
                    datalevel.Columns.RemoveAt(5);
                    datalevel.Columns["degree"].DisplayIndex = datalevel.ColumnCount - 2;

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
             
            int rowIndex = 0;
            foreach (DataGridViewRow dgvRow in datalevel.Rows)
            {
                if (dgvRow.Cells[5].FormattedValue.ToString() == "1")
                // Here I'd update the row (at this point I already have the row index)
                {
                    dgvRow.Cells[0].Value = "Unsatisfactory";
                }
                if (dgvRow.Cells[5].FormattedValue.ToString() == "2")
                {
                    dgvRow.Cells[0].Value = "Fair";
                }
                if (dgvRow.Cells[5].FormattedValue.ToString() == "3")
                {
                    dgvRow.Cells[0].Value = "Good";
                }
                if (dgvRow.Cells[5].FormattedValue.ToString() == "4")
                {
                    dgvRow.Cells[0].Value = "Exceptional";
                }
                rowIndex++;
            }
            datalevel.Columns.RemoveAt(5);
            datalevel.Columns["degree"].DisplayIndex = datalevel.ColumnCount - 2;

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

            //opens the student registration form
            SRfrm i = new SRfrm();
            this.Hide();
            i.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            //open the registered student list form
            studentlist h = new studentlist();
            this.Hide();
            h.Show();
        }


        private void btnAddclo_Click_1(object sender, EventArgs e)
        {
            //opens the registereed Student list
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open the clo page
            Clos h = new Clos();
            this.Hide();
            h.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Opens the attendance form if attendance has taken for that date
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

        private void button3_Click(object sender, EventArgs e)
        {
            //show the attendance in new form for any day
            Showattendence y = new Showattendence();
            this.Hide();
            y.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Opens the assessment manage form
            assessmentfrm l = new assessmentfrm();
            this.Hide();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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