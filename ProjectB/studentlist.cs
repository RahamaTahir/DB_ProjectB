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
    
        public static int C_Id;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            C_Id = Convert.ToInt32(this.studentdata.Rows[e.RowIndex].Cells[3].Value);
            if (studentdata.Columns[e.ColumnIndex].Name == "btn_del")
            {
                string cmd = @"delete from Student where Id=" + C_Id; ;
                int i = databaseconnection.get_instance().Executequery(cmd);
                if (i > 0)
                {
                    MessageBox.Show("Deleted.");
                    studentlist d = new studentlist();
                    this.Hide();
                    d.Show();
                }
            }
           
            if (studentdata.Columns[e.ColumnIndex].Name== "edit")
            {   
                SRfrm h = new SRfrm();
                this.Hide();
                h.Show();
            }
        }

        private void studentlist_Load(object sender, EventArgs e)
        {
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.Name = "Del";
            ///btn.Text = "Delete";
            //btn.UseColumnTextForButtonValue = false;

            string cmd = "SELECT * FROM Student";
            BindingSource s = new BindingSource();
            s.DataSource = databaseconnection.get_instance().Listofstudents(cmd);
            studentdata.DataSource = s;

            //here I covwet the status from 5,6 to Active, InActive
            int rowIndex = 0;
            foreach (DataGridViewRow dgvRow in studentdata.Rows)
            {
                if (dgvRow.Cells[9].FormattedValue.ToString() == "5")
                // Here I'd update the row (at this point I already have the row index)
                {
                    dgvRow.Cells[0].Value = "Active" ;
                }
                if (dgvRow.Cells[9].FormattedValue.ToString() == "6")
                {
                    dgvRow.Cells[0].Value ="InActive";
                }
                rowIndex++;
                
            }
            //studentdata.Columns.Add(btn);
            studentdata.Columns.RemoveAt(9);
            studentdata.Columns["txt_status"].DisplayIndex = studentdata.ColumnCount - 1;
            studentdata.Columns["edit"].DisplayIndex = studentdata.ColumnCount - 1;
            studentdata.Columns["btn_del"].DisplayIndex = studentdata.ColumnCount - 1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
    }
}
