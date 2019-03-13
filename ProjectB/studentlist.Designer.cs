namespace ProjectB
{
    partial class studentlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.studentdata = new System.Windows.Forms.DataGridView();
            this.txt_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.studentdata, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.89487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.10513F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // studentdata
            // 
            this.studentdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_status,
            this.btn_del,
            this.edit});
            this.studentdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentdata.Location = new System.Drawing.Point(3, 113);
            this.studentdata.Name = "studentdata";
            this.studentdata.Size = new System.Drawing.Size(689, 293);
            this.studentdata.TabIndex = 1;
            this.studentdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txt_status
            // 
            this.txt_status.HeaderText = "Status";
            this.txt_status.Name = "txt_status";
            // 
            // btn_del
            // 
            this.btn_del.FillWeight = 150F;
            this.btn_del.HeaderText = "DELETE";
            this.btn_del.Name = "btn_del";
            this.btn_del.Text = "Delete";
            this.btn_del.UseColumnTextForButtonValue = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "EDIT";
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // studentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "studentlist";
            this.Text = "studentlist";
            this.Load += new System.EventHandler(this.studentlist_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView studentdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_del;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}