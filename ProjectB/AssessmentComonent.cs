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
    public partial class AssessmentComonent : Form
    {
        public AssessmentComonent()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main_Screen i = new Main_Screen();
            this.Hide();
            i.Show();
        }

        private void AssessmentComonent_Load(object sender, EventArgs e)
        {
            SqlDataReader read1 = databaseconnection.get_instance().Getdata("SELECT * FROM Assessment");
            while (read1.Read())
            {
                if (assessmentfrm.Assess_id == Convert.ToInt32(read1[0]))
                {
                    comboAssessname.Text = read1[1].ToString();
                }
            }
            SqlDataReader cmd = databaseconnection.get_instance().Getdata("SELECT * FROM Rubric");
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Details", typeof(string));
            dt.Load(cmd);

            txtcomborubric.ValueMember = "Id";
            txtcomborubric.DisplayMember = "Details";
            txtcomborubric.DataSource = dt;

            txtcomborubric.Text = "";

            string reader = string.Format("SELECT * FROM AssessmentComponent Where AssessmentId ={0}", assessmentfrm.Assess_id);

            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listofcomponents(reader);
            dataComponent.DataSource = s;

            dataComponent.Columns["delCom"].DisplayIndex = dataComponent.ColumnCount - 1;
            dataComponent.Columns["updateCom"].DisplayIndex = dataComponent.ColumnCount - 1;

        }

        private static bool flag = true;
        Assessmentcomponent component = new Assessmentcomponent();
        private void btncomponentsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                component.Name = txtAssessComN.Text;
                component.TotalMarks = Int32.Parse(txtcommarks.Text);
                component.DateCreated = DateTime.Now.Date;
                component.AssessmentId = assessmentfrm.Assess_id;
                if (flag)
                {
                    component.DateUpdated = DateTime.Now.Date;
                    SqlDataReader cmd = databaseconnection.get_instance().Getdata("Select * From Rubric");
                    while (cmd.Read())
                    {
                        if (txtcomborubric.Text == cmd[1].ToString())
                        {
                            component.RubricId = Convert.ToInt32(cmd[0]);
                        }
                    }
                    string cmd1 = $"INSERT INTO AssessmentComponent(Name,RubricId,TotalMarks,DateCreated,DateUpdated,AssessmentId) VALUES('{component.Name}','{component.RubricId}','{component.TotalMarks}','{component.DateCreated}','{component.DateUpdated}','{component.AssessmentId}')";
                    int rows = databaseconnection.get_instance().Executequery(cmd1);
                    MessageBox.Show(String.Format("{0} rows affected", rows));
                }
                else
                {
                    SqlDataReader cmd = databaseconnection.get_instance().Getdata("Select * From Rubric");
                    while (cmd.Read())
                    {
                        if (txtcomborubric.Text == cmd[1].ToString())
                        {
                            component.RubricId = Convert.ToInt32(cmd[0]);
                        }
                    }
                    string cmd1 = string.Format("UPDATE  AssessmentComponent SET Name = '{0}',RubricId = '{1}',TotalMarks = '{2}',DateUpdated ='{3}'  WHERE Id= '{4}'", component.Name, component.RubricId, component.TotalMarks, DateTime.Now.Date, component_id);
                    int rows = databaseconnection.get_instance().Executequery(cmd1);
                    MessageBox.Show(String.Format("Updated", rows));
                    flag = true;
                }
                AssessmentComonent_Load(sender, e);

                txtAssessComN.Text = "";
                txtcommarks.Text = "";
                comboAssessname.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int component_id;
        private void dataComponent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            component_id = Convert.ToInt32(this.dataComponent.Rows[e.RowIndex].Cells[2].Value);
            if (dataComponent.Columns[e.ColumnIndex].Name == "updateCom")
            {
                flag = false;
                SqlDataReader AssessmentCom = databaseconnection.get_instance().Getdata("SELECT * FROM AssessmentComponent");
                if (component_id != 0)
                {
                    while (AssessmentCom.Read())
                    {
                        if (AssessmentCom[0].ToString() == component_id.ToString())
                        {
                            txtAssessComN.Text = AssessmentCom[1].ToString();
                            SqlDataReader AssessmentComp = databaseconnection.get_instance().Getdata("SELECT * FROM Rubric");
                            if (AssessmentComp != null)
                            {
                                while (AssessmentComp.Read())
                                {
                                    if (AssessmentComp[0].ToString() == AssessmentCom[2].ToString())
                                    {
                                        txtcomborubric.Text = AssessmentComp[1].ToString();
                                    }

                                }
                            }
                            SqlDataReader AssessmentComp1 = databaseconnection.get_instance().Getdata("SELECT * FROM Assessment");
                            if (AssessmentComp1 != null)
                            {
                                while (AssessmentComp1.Read())
                                {
                                    if (AssessmentComp1[0].ToString() == AssessmentCom[6].ToString())
                                    {
                                        comboAssessname.Text = AssessmentComp1[1].ToString();
                                    }

                                }
                            }
                            txtcommarks.Text = AssessmentCom[3].ToString();

                        }
                    }
                }
            }
            if (dataComponent.Columns[e.ColumnIndex].Name == "delCom")
            {
                string cmd = @"delete from AssessmentComponent where Id=" + component_id;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Deleted.");
                    string cmd1 = string.Format("SELECT * FROM AssessmentComponent Where Id={0}", component_id);
                    BindingSource s = new BindingSource();
                    s.DataSource = databaseconnection.get_instance().Listoflevels(cmd1);
                    dataComponent.DataSource = s;
                    AssessmentComonent_Load(sender, e);

                }
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            SRfrm x = new SRfrm();
            this.Hide();
            x.Show();

        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            studentlist u = new studentlist();
            this.Hide();
            u.Show();

        }

        Clos n = new Clos();
        private void btnAddclo_Click(object sender, EventArgs e)
        {
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool y = false;
            SqlDataReader date1 = databaseconnection.get_instance().Getdata(string.Format("SELECT * FROM ClassAttendance"));
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
            if (y == false)
            {

                attendence h = new attendence();
                this.Hide();
                h.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            assessmentfrm s = new assessmentfrm();
            this.Hide();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssessmentComonent j = new AssessmentComonent();
            this.Hide();
            j.Show();
        }
    }
}
