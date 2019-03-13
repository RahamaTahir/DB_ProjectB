namespace ProjectB
{
    partial class Clos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloadd = new System.Windows.Forms.Button();
            this.btnShowclo = new System.Windows.Forms.Button();
            this.txtCloname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.clodata = new System.Windows.Forms.DataGridView();
            this.btn_addRubric = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_del1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Clo_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCloname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnAddclo = new System.Windows.Forms.Button();
            this.btnStdList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clodata)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
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
            // btnCloadd
            // 
            this.btnCloadd.Location = new System.Drawing.Point(16, 13);
            this.btnCloadd.Name = "btnCloadd";
            this.btnCloadd.Size = new System.Drawing.Size(115, 41);
            this.btnCloadd.TabIndex = 2;
            this.btnCloadd.Text = "Save";
            this.btnCloadd.UseVisualStyleBackColor = true;
            this.btnCloadd.Click += new System.EventHandler(this.btnCloadd_Click);
            // 
            // btnShowclo
            // 
            this.btnShowclo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowclo.Location = new System.Drawing.Point(0, 0);
            this.btnShowclo.Name = "btnShowclo";
            this.btnShowclo.Size = new System.Drawing.Size(600, 51);
            this.btnShowclo.TabIndex = 3;
            this.btnShowclo.Text = "Show Clo\'s";
            this.btnShowclo.UseVisualStyleBackColor = true;
            this.btnShowclo.Click += new System.EventHandler(this.btnShowclo_Click);
            // 
            // txtCloname
            // 
            this.txtCloname.Location = new System.Drawing.Point(95, 13);
            this.txtCloname.Multiline = true;
            this.txtCloname.Name = "txtCloname";
            this.txtCloname.Size = new System.Drawing.Size(320, 39);
            this.txtCloname.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 79);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 421);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCloadd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(466, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 71);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtCloname);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(466, 71);
            this.panel7.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(800, 421);
            this.panel9.TabIndex = 5;
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
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btn_back);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(546, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(254, 79);
            this.panel10.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnStdList);
            this.panel8.Controls.Add(this.btnAddclo);
            this.panel8.Controls.Add(this.btnregister);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 421);
            this.panel8.TabIndex = 0;
            // 
            // clodata
            // 
            this.clodata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clodata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clo_edit,
            this.btn_del1,
            this.btn_addRubric});
            this.clodata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clodata.Location = new System.Drawing.Point(0, 122);
            this.clodata.Name = "clodata";
            this.clodata.Size = new System.Drawing.Size(600, 299);
            this.clodata.TabIndex = 3;
            this.clodata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clodata_CellContentClick);
            // 
            // btn_addRubric
            // 
            this.btn_addRubric.HeaderText = "Add Rubric";
            this.btn_addRubric.Name = "btn_addRubric";
            this.btn_addRubric.Text = "Add Rubric";
            // 
            // btn_del1
            // 
            this.btn_del1.HeaderText = "Delete";
            this.btn_del1.Name = "btn_del1";
            this.btn_del1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_del1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_del1.Text = "Delete";
            this.btn_del1.UseColumnTextForButtonValue = true;
            // 
            // Clo_edit
            // 
            this.Clo_edit.HeaderText = "Edit";
            this.Clo_edit.Name = "Clo_edit";
            this.Clo_edit.Text = "Edit";
            this.Clo_edit.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCloname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 71);
            this.panel5.TabIndex = 3;
            // 
            // lblCloname
            // 
            this.lblCloname.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloname.Location = new System.Drawing.Point(3, 13);
            this.lblCloname.Name = "lblCloname";
            this.lblCloname.Size = new System.Drawing.Size(97, 42);
            this.lblCloname.TabIndex = 1;
            this.lblCloname.Text = "Name";
            this.lblCloname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCloname.Click += new System.EventHandler(this.lblCloname_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clodata);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 421);
            this.panel3.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel5);
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(600, 71);
            this.panel11.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnShowclo);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 71);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(600, 51);
            this.panel12.TabIndex = 1;
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
            // Clos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Clos";
            this.Text = "Clos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clodata)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloadd;
        private System.Windows.Forms.Button btnShowclo;
        private System.Windows.Forms.TextBox txtCloname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView clodata;
        private System.Windows.Forms.DataGridViewButtonColumn Clo_edit;
        private System.Windows.Forms.DataGridViewButtonColumn btn_del1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_addRubric;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCloname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnStdList;
        private System.Windows.Forms.Button btnAddclo;
        private System.Windows.Forms.Button btnregister;
    }
}