namespace Pointofsales1
{
    partial class Registeremployee
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearchempdetails = new System.Windows.Forms.TextBox();
            this.btnsearchempdetails = new System.Windows.Forms.Button();
            this.empdgv = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecommencedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possystemDataSet1 = new Pointofsales1.PossystemDataSet1();
            this.add_employeeTableAdapter = new Pointofsales1.PossystemDataSet1TableAdapters.add_employeeTableAdapter();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(437, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE DETAILS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 425);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.txtsearchempdetails);
            this.panel3.Controls.Add(this.btnsearchempdetails);
            this.panel3.Location = new System.Drawing.Point(234, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1038, 60);
            this.panel3.TabIndex = 2;
            // 
            // txtsearchempdetails
            // 
            this.txtsearchempdetails.ForeColor = System.Drawing.Color.Black;
            this.txtsearchempdetails.Location = new System.Drawing.Point(113, 12);
            this.txtsearchempdetails.Multiline = true;
            this.txtsearchempdetails.Name = "txtsearchempdetails";
            this.txtsearchempdetails.Size = new System.Drawing.Size(223, 31);
            this.txtsearchempdetails.TabIndex = 1;
            // 
            // btnsearchempdetails
            // 
            this.btnsearchempdetails.BackColor = System.Drawing.Color.Black;
            this.btnsearchempdetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchempdetails.ForeColor = System.Drawing.Color.White;
            this.btnsearchempdetails.Location = new System.Drawing.Point(10, 12);
            this.btnsearchempdetails.Name = "btnsearchempdetails";
            this.btnsearchempdetails.Size = new System.Drawing.Size(85, 31);
            this.btnsearchempdetails.TabIndex = 0;
            this.btnsearchempdetails.Text = "Search";
            this.btnsearchempdetails.UseVisualStyleBackColor = false;
            this.btnsearchempdetails.Click += new System.EventHandler(this.btnsearchempdetails_Click);
            // 
            // empdgv
            // 
            this.empdgv.AutoGenerateColumns = false;
            this.empdgv.BackgroundColor = System.Drawing.Color.White;
            this.empdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.nationalidDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.maritalstatusDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn,
            this.shiftnameDataGridViewTextBoxColumn,
            this.datecommencedDataGridViewTextBoxColumn,
            this.basicsalaryDataGridViewTextBoxColumn});
            this.empdgv.DataSource = this.addemployeeBindingSource;
            this.empdgv.Location = new System.Drawing.Point(228, 111);
            this.empdgv.Name = "empdgv";
            this.empdgv.Size = new System.Drawing.Size(1044, 359);
            this.empdgv.TabIndex = 3;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "add_ress";
            this.addressDataGridViewTextBoxColumn.HeaderText = "add_ress";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // nationalidDataGridViewTextBoxColumn
            // 
            this.nationalidDataGridViewTextBoxColumn.DataPropertyName = "national_id";
            this.nationalidDataGridViewTextBoxColumn.HeaderText = "national_id";
            this.nationalidDataGridViewTextBoxColumn.Name = "nationalidDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // maritalstatusDataGridViewTextBoxColumn
            // 
            this.maritalstatusDataGridViewTextBoxColumn.DataPropertyName = "marital_status";
            this.maritalstatusDataGridViewTextBoxColumn.HeaderText = "marital_status";
            this.maritalstatusDataGridViewTextBoxColumn.Name = "maritalstatusDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "job_title";
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // shiftnameDataGridViewTextBoxColumn
            // 
            this.shiftnameDataGridViewTextBoxColumn.DataPropertyName = "shift_name";
            this.shiftnameDataGridViewTextBoxColumn.HeaderText = "shift_name";
            this.shiftnameDataGridViewTextBoxColumn.Name = "shiftnameDataGridViewTextBoxColumn";
            // 
            // datecommencedDataGridViewTextBoxColumn
            // 
            this.datecommencedDataGridViewTextBoxColumn.DataPropertyName = "date_commenced";
            this.datecommencedDataGridViewTextBoxColumn.HeaderText = "date_commenced";
            this.datecommencedDataGridViewTextBoxColumn.Name = "datecommencedDataGridViewTextBoxColumn";
            // 
            // basicsalaryDataGridViewTextBoxColumn
            // 
            this.basicsalaryDataGridViewTextBoxColumn.DataPropertyName = "basic_salary";
            this.basicsalaryDataGridViewTextBoxColumn.HeaderText = "basic_salary";
            this.basicsalaryDataGridViewTextBoxColumn.Name = "basicsalaryDataGridViewTextBoxColumn";
            // 
            // addemployeeBindingSource
            // 
            this.addemployeeBindingSource.DataMember = "add_employee";
            this.addemployeeBindingSource.DataSource = this.possystemDataSet1;
            // 
            // possystemDataSet1
            // 
            this.possystemDataSet1.DataSetName = "PossystemDataSet1";
            this.possystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_employeeTableAdapter
            // 
            this.add_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel1.Location = new System.Drawing.Point(1247, -2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(23, 25);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(1212, -14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 40);
            this.label15.TabIndex = 9;
            this.label15.Text = "-";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Registeremployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1282, 550);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.empdgv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registeremployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeremployee";
            this.Load += new System.EventHandler(this.Registeremployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsearchempdetails;
        private System.Windows.Forms.Button btnsearchempdetails;
        private System.Windows.Forms.DataGridView empdgv;
        private PossystemDataSet1 possystemDataSet1;
        private System.Windows.Forms.BindingSource addemployeeBindingSource;
        private PossystemDataSet1TableAdapters.add_employeeTableAdapter add_employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecommencedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicsalaryDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label15;
    }
}