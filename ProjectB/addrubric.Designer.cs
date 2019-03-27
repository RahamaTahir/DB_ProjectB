namespace ProjectB
{
    partial class addrubric
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.datarubric = new System.Windows.Forms.DataGridView();
            this.btn_RubricDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_updaterubric = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_rubriclevel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.clonamelbl = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtrubricdetails = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCloname = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnrubricadd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStdList = new System.Windows.Forms.Button();
            this.btnAddclo = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datarubric)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.datarubric);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(200, 205);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(600, 348);
            this.panel15.TabIndex = 5;
            // 
            // datarubric
            // 
            this.datarubric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datarubric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_RubricDel,
            this.btn_updaterubric,
            this.btn_rubriclevel});
            this.datarubric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datarubric.Location = new System.Drawing.Point(0, 0);
            this.datarubric.Name = "datarubric";
            this.datarubric.Size = new System.Drawing.Size(600, 348);
            this.datarubric.TabIndex = 0;
            this.datarubric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_RubricDel
            // 
            this.btn_RubricDel.HeaderText = "Delete Rubric";
            this.btn_RubricDel.Name = "btn_RubricDel";
            this.btn_RubricDel.Text = "Delete";
            this.btn_RubricDel.UseColumnTextForButtonValue = true;
            // 
            // btn_updaterubric
            // 
            this.btn_updaterubric.HeaderText = "Update Rubric";
            this.btn_updaterubric.Name = "btn_updaterubric";
            this.btn_updaterubric.Text = "Update";
            this.btn_updaterubric.UseColumnTextForButtonValue = true;
            // 
            // btn_rubriclevel
            // 
            this.btn_rubriclevel.HeaderText = "Manage Level";
            this.btn_rubriclevel.Name = "btn_rubriclevel";
            this.btn_rubriclevel.Text = "Manage ";
            this.btn_rubriclevel.UseColumnTextForButtonValue = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.clonamelbl);
            this.panel14.Controls.Add(this.panel13);
            this.panel14.Controls.Add(this.label3);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(200, 156);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(600, 49);
            this.panel14.TabIndex = 4;
            // 
            // clonamelbl
            // 
            this.clonamelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clonamelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clonamelbl.Location = new System.Drawing.Point(317, 0);
            this.clonamelbl.Name = "clonamelbl";
            this.clonamelbl.Size = new System.Drawing.Size(283, 49);
            this.clonamelbl.TabIndex = 7;
            this.clonamelbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(194, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(123, 49);
            this.panel13.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 49);
            this.label6.TabIndex = 6;
            this.label6.Text = "Clo Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rubric Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 68);
            this.panel5.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(466, 68);
            this.panel11.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtrubricdetails);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(139, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(327, 68);
            this.panel16.TabIndex = 7;
            // 
            // txtrubricdetails
            // 
            this.txtrubricdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtrubricdetails.Location = new System.Drawing.Point(0, 0);
            this.txtrubricdetails.Name = "txtrubricdetails";
            this.txtrubricdetails.Size = new System.Drawing.Size(327, 68);
            this.txtrubricdetails.TabIndex = 1;
            this.txtrubricdetails.Text = "";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblCloname);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(139, 68);
            this.panel9.TabIndex = 6;
            // 
            // lblCloname
            // 
            this.lblCloname.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloname.Location = new System.Drawing.Point(4, 18);
            this.lblCloname.Name = "lblCloname";
            this.lblCloname.Size = new System.Drawing.Size(135, 42);
            this.lblCloname.TabIndex = 1;
            this.lblCloname.Text = "Rubric Details";
            this.lblCloname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnrubricadd);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(466, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(134, 68);
            this.panel12.TabIndex = 7;
            // 
            // btnrubricadd
            // 
            this.btnrubricadd.Location = new System.Drawing.Point(16, 13);
            this.btnrubricadd.Name = "btnrubricadd";
            this.btnrubricadd.Size = new System.Drawing.Size(115, 41);
            this.btnrubricadd.TabIndex = 2;
            this.btnrubricadd.Text = "Save";
            this.btnrubricadd.UseVisualStyleBackColor = true;
            this.btnrubricadd.Click += new System.EventHandler(this.btnCloadd_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 465);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.btnStdList);
            this.panel8.Controls.Add(this.btnAddclo);
            this.panel8.Controls.Add(this.btnregister);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 463);
            this.panel8.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Take Attendence ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Manage Rubric & Rubric Level";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStdList
            // 
            this.btnStdList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStdList.Location = new System.Drawing.Point(0, 66);
            this.btnStdList.Name = "btnStdList";
            this.btnStdList.Size = new System.Drawing.Size(198, 31);
            this.btnStdList.TabIndex = 4;
            this.btnStdList.Text = "View Student List";
            this.btnStdList.UseVisualStyleBackColor = true;
            this.btnStdList.Click += new System.EventHandler(this.btnStdList_Click);
            // 
            // btnAddclo
            // 
            this.btnAddclo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddclo.Location = new System.Drawing.Point(0, 32);
            this.btnAddclo.Name = "btnAddclo";
            this.btnAddclo.Size = new System.Drawing.Size(198, 34);
            this.btnAddclo.TabIndex = 5;
            this.btnAddclo.Text = "Add CLO";
            this.btnAddclo.UseVisualStyleBackColor = true;
            this.btnAddclo.Click += new System.EventHandler(this.btnAddclo_Click);
            // 
            // btnregister
            // 
            this.btnregister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnregister.Location = new System.Drawing.Point(0, 0);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(198, 32);
            this.btnregister.TabIndex = 3;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btn_back);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(-56, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(254, 463);
            this.panel10.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(105, 32);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(146, 41);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Bact to Main Screen";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 463);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add CLO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(544, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 86);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bact to Main Screen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(798, 86);
            this.panel7.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(796, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Rubric(s)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Manage Assessment(s)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Attendance List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addrubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.panel1);
            this.Name = "addrubric";
            this.Text = "Lab Assessment Project";
            this.Load += new System.EventHandler(this.addrubric_Load);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datarubric)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnStdList;
        private System.Windows.Forms.Button btnAddclo;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblCloname;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnrubricadd;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView datarubric;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clonamelbl;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.RichTextBox txtrubricdetails;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_RubricDel;
        private System.Windows.Forms.DataGridViewButtonColumn btn_updaterubric;
        private System.Windows.Forms.DataGridViewButtonColumn btn_rubriclevel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}