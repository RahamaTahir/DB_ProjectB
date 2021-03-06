﻿using System;
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

        //declare rubric type object to access it to the whole form
        newrubric rubric = new newrubric();

        //flag for edit function operate on the same page IF TRUE(Create object) IF FALSE(edit object)
        bool flag = true;

        //to store the id of rubric to access it to  other forms
        public static int id;

        /// <summary>
        /// Clo add and edit in this function using bool flag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// When load the form it update the datagrid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// when any delete, update, manage rubric button click it do the corresponding action 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(this.datarubric.Rows[e.RowIndex].Cells[3].Value);
            if (datarubric.Columns[e.ColumnIndex].Name == "btn_updaterubric")
            {
                //updates the value of register form value to edit the rubric
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
                //First it delete the Result of that student so that it don't conflict with the ID's
                string cmd5 = @"delete from StudentResult where StudentId=" + id;
                int y = databaseconnection.get_instance().Executequery(cmd5);

                SqlDataReader reader1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM RubricLevel Where RubricId = '{0}'",id ));
                if (reader1 != null)
                {
                    while (reader1.Read())
                    {
                        //Here it delete the Rubric levels related to that rubric
                        string cmd2 = @"delete from RubricLevel where RubricId=" + id; ;
                        int s = databaseconnection.get_instance().Executequery(cmd2);

                    }
                }
                SqlDataReader reader = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM AssessmentComponent WHERE RubricId='{0}'", id));
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        //Now it delete the Assessment Components that have this rubric ID
                        string cmd6 = @"delete from AssessmentComponent where RubricId=" + id; ;
                        int z = databaseconnection.get_instance().Executequery(cmd6);

                    }
                }
                //It delete the rubric
                string cmd = @"delete from Rubric where Id=" + id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Assessment Components Related to this Rubric are alsso deleted");
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
            //show the Student Register form
            SRfrm i = new SRfrm();
            this.Hide();
            i.Show();
        }

        private void btnAddclo_Click(object sender, EventArgs e)
        {
            //show the Clo manage form
            Clos h = new Clos();
            this.Hide();
            h.Show();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            //Show the student list form 
            studentlist h = new studentlist();
            this.Hide();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Shows the main screen
            Main_Screen g = new Main_Screen();
            this.Hide();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Show the Clos screen
            Clos h = new Clos();
            this.Hide();
            h.Show();
        
    }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Open the attendance Form
            attendence h = new attendence();
            this.Hide();
            h.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Opeen the attendance Form
            Showattendence i = new Showattendence();
            this.Hide();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //opens the manage assessment Form
            assessmentfrm k = new assessmentfrm();
            this.Hide();
            k.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Opens the result calulation form
            resultStudentForm j = new resultStudentForm();
            this.Hide();
            j.Show();
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
