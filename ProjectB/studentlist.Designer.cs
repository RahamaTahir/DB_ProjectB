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
            this.studentdata = new System.Windows.Forms.DataGridView();
            this.txt_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStdList = new System.Windows.Forms.Button();
            this.btnAddclo = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentdata
            // 
            this.studentdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_status,
            this.btn_del,
            this.edit});
            this.studentdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentdata.Location = new System.Drawing.Point(0, 0);
            this.studentdata.Name = "studentdata";
            this.studentdata.Size = new System.Drawing.Size(600, 371);
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
            this.btn_del.HeaderText = "Delete";
            this.btn_del.Name = "btn_del";
            this.btn_del.Text = "Delete";
            this.btn_del.UseColumnTextForButtonValue = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btn_back);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(546, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(254, 79);
            this.panel10.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(105, 32);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(146, 41);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Bact to Main Screen";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 79);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 77);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registered Students List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnStdList);
            this.panel2.Controls.Add(this.btnAddclo);
            this.panel2.Controls.Add(this.btnregister);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 371);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Take Attendence ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Manage Rubric & Rubric Level";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStdList
            // 
            this.btnStdList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStdList.Location = new System.Drawing.Point(0, 66);
            this.btnStdList.Name = "btnStdList";
            this.btnStdList.Size = new System.Drawing.Size(200, 31);
            this.btnStdList.TabIndex = 7;
            this.btnStdList.Text = "View Student List";
            this.btnStdList.UseVisualStyleBackColor = true;
            this.btnStdList.Click += new System.EventHandler(this.btnStdList_Click);
            // 
            // btnAddclo
            // 
            this.btnAddclo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddclo.Location = new System.Drawing.Point(0, 32);
            this.btnAddclo.Name = "btnAddclo";
            this.btnAddclo.Size = new System.Drawing.Size(200, 34);
            this.btnAddclo.TabIndex = 8;
            this.btnAddclo.Text = "Add CLO";
            this.btnAddclo.UseVisualStyleBackColor = true;
            this.btnAddclo.Click += new System.EventHandler(this.btnAddclo_Click);
            // 
            // btnregister
            // 
            this.btnregister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnregister.Location = new System.Drawing.Point(0, 0);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(200, 32);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.studentdata);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 371);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Manage Assessment(s)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 31);
            this.button5.TabIndex = 18;
            this.button5.Text = "Attendance List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // studentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "studentlist";
            this.Text = "Lab Assessment Project";
            this.Load += new System.EventHandler(this.studentlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentdata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStdList;
        private System.Windows.Forms.Button btnAddclo;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_del;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}