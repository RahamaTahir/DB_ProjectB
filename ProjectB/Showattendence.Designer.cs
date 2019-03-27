namespace ProjectB
{
    partial class Showattendence
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataattendance = new System.Windows.Forms.DataGridView();
            this.statusA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnrubricadd = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCloname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStdList = new System.Windows.Forms.Button();
            this.btnAddclo = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataattendance)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 100);
            this.label2.TabIndex = 11;
            this.label2.Text = "Attendence List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(546, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(254, 100);
            this.panel6.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bact to Main Screen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 350);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 348);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataattendance);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(598, 281);
            this.panel7.TabIndex = 1;
            // 
            // dataattendance
            // 
            this.dataattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataattendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusA});
            this.dataattendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataattendance.Location = new System.Drawing.Point(0, 0);
            this.dataattendance.Name = "dataattendance";
            this.dataattendance.Size = new System.Drawing.Size(598, 281);
            this.dataattendance.TabIndex = 1;
            this.dataattendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datarubric_CellContentClick);
            // 
            // statusA
            // 
            this.statusA.HeaderText = "Attendance Status";
            this.statusA.Name = "statusA";
            this.statusA.Width = 150;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 67);
            this.panel5.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dateTimePicker1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(139, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(305, 67);
            this.panel10.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnrubricadd);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(444, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(154, 67);
            this.panel12.TabIndex = 10;
            // 
            // btnrubricadd
            // 
            this.btnrubricadd.Location = new System.Drawing.Point(16, 13);
            this.btnrubricadd.Name = "btnrubricadd";
            this.btnrubricadd.Size = new System.Drawing.Size(115, 41);
            this.btnrubricadd.TabIndex = 2;
            this.btnrubricadd.Text = "Show Attendance";
            this.btnrubricadd.UseVisualStyleBackColor = true;
            this.btnrubricadd.Click += new System.EventHandler(this.btnrubricadd_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblCloname);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(139, 67);
            this.panel9.TabIndex = 9;
            // 
            // lblCloname
            // 
            this.lblCloname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCloname.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloname.Location = new System.Drawing.Point(0, 0);
            this.lblCloname.Name = "lblCloname";
            this.lblCloname.Size = new System.Drawing.Size(139, 67);
            this.lblCloname.TabIndex = 1;
            this.lblCloname.Text = "Attendance Date";
            this.lblCloname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 348);
            this.panel2.TabIndex = 0;
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
            this.panel8.Size = new System.Drawing.Size(200, 348);
            this.panel8.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Take Attendance ";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 31);
            this.button3.TabIndex = 15;
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
            this.button5.TabIndex = 14;
            this.button5.Text = "Attendance List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Showattendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Showattendence";
            this.Text = "Lab Assessment Project";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataattendance)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStdList;
        private System.Windows.Forms.Button btnAddclo;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnrubricadd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblCloname;
        private System.Windows.Forms.DataGridView dataattendance;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusA;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}