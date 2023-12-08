namespace Pointofsales1
{
    partial class CashierPage
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtCashieremail = new System.Windows.Forms.TextBox();
            this.txtCashiercontact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewCashier = new System.Windows.Forms.Button();
            this.dtpCashier = new System.Windows.Forms.DateTimePicker();
            this.txtCashierpassword = new System.Windows.Forms.TextBox();
            this.txtCashierusername = new System.Windows.Forms.TextBox();
            this.txtCashierlname = new System.Windows.Forms.TextBox();
            this.txtCashierfname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCashierdelete = new System.Windows.Forms.Button();
            this.btnCashierupdate = new System.Windows.Forms.Button();
            this.btnCashierdisplay = new System.Windows.Forms.Button();
            this.txtCashiersearch = new System.Windows.Forms.TextBox();
            this.btnCashiersearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possystemDataSet1 = new Pointofsales1.PossystemDataSet1();
            this.cashierTableAdapter = new Pointofsales1.PossystemDataSet1TableAdapters.cashierTableAdapter();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCashieremail);
            this.panel1.Controls.Add(this.txtCashiercontact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addNewCashier);
            this.panel1.Controls.Add(this.dtpCashier);
            this.panel1.Controls.Add(this.txtCashierpassword);
            this.panel1.Controls.Add(this.txtCashierusername);
            this.panel1.Controls.Add(this.txtCashierlname);
            this.panel1.Controls.Add(this.txtCashierfname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 506);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "EMAIL :";
            // 
            // txtCashieremail
            // 
            this.txtCashieremail.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashieremail.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashieremail.Location = new System.Drawing.Point(179, 283);
            this.txtCashieremail.Multiline = true;
            this.txtCashieremail.Name = "txtCashieremail";
            this.txtCashieremail.Size = new System.Drawing.Size(259, 31);
            this.txtCashieremail.TabIndex = 42;
            // 
            // txtCashiercontact
            // 
            this.txtCashiercontact.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashiercontact.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashiercontact.Location = new System.Drawing.Point(179, 236);
            this.txtCashiercontact.Multiline = true;
            this.txtCashiercontact.Name = "txtCashiercontact";
            this.txtCashiercontact.Size = new System.Drawing.Size(259, 29);
            this.txtCashiercontact.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "CONTACT :";
            // 
            // addNewCashier
            // 
            this.addNewCashier.BackColor = System.Drawing.Color.Black;
            this.addNewCashier.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCashier.ForeColor = System.Drawing.Color.White;
            this.addNewCashier.Location = new System.Drawing.Point(285, 447);
            this.addNewCashier.Name = "addNewCashier";
            this.addNewCashier.Size = new System.Drawing.Size(153, 34);
            this.addNewCashier.TabIndex = 39;
            this.addNewCashier.Text = "Add New";
            this.addNewCashier.UseVisualStyleBackColor = false;
            this.addNewCashier.Click += new System.EventHandler(this.addNewCashier_Click);
            // 
            // dtpCashier
            // 
            this.dtpCashier.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCashier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCashier.Location = new System.Drawing.Point(179, 179);
            this.dtpCashier.Name = "dtpCashier";
            this.dtpCashier.Size = new System.Drawing.Size(259, 25);
            this.dtpCashier.TabIndex = 38;
            // 
            // txtCashierpassword
            // 
            this.txtCashierpassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierpassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashierpassword.Location = new System.Drawing.Point(179, 380);
            this.txtCashierpassword.Multiline = true;
            this.txtCashierpassword.Name = "txtCashierpassword";
            this.txtCashierpassword.Size = new System.Drawing.Size(259, 31);
            this.txtCashierpassword.TabIndex = 37;
            // 
            // txtCashierusername
            // 
            this.txtCashierusername.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierusername.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashierusername.Location = new System.Drawing.Point(179, 327);
            this.txtCashierusername.Multiline = true;
            this.txtCashierusername.Name = "txtCashierusername";
            this.txtCashierusername.Size = new System.Drawing.Size(259, 31);
            this.txtCashierusername.TabIndex = 36;
            // 
            // txtCashierlname
            // 
            this.txtCashierlname.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierlname.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashierlname.Location = new System.Drawing.Point(179, 133);
            this.txtCashierlname.Multiline = true;
            this.txtCashierlname.Name = "txtCashierlname";
            this.txtCashierlname.Size = new System.Drawing.Size(259, 31);
            this.txtCashierlname.TabIndex = 35;
            // 
            // txtCashierfname
            // 
            this.txtCashierfname.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashierfname.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtCashierfname.Location = new System.Drawing.Point(179, 87);
            this.txtCashierfname.Multiline = true;
            this.txtCashierfname.Name = "txtCashierfname";
            this.txtCashierfname.Size = new System.Drawing.Size(259, 31);
            this.txtCashierfname.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "PASSWORD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "USERNAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "DATE OF BIRTH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "LAST NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "FIRST NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(195, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "CASHIER USER ACCOUNT";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(652, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Exit(0)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCashierdelete
            // 
            this.btnCashierdelete.BackColor = System.Drawing.Color.Black;
            this.btnCashierdelete.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierdelete.ForeColor = System.Drawing.Color.White;
            this.btnCashierdelete.Location = new System.Drawing.Point(366, 448);
            this.btnCashierdelete.Name = "btnCashierdelete";
            this.btnCashierdelete.Size = new System.Drawing.Size(108, 35);
            this.btnCashierdelete.TabIndex = 6;
            this.btnCashierdelete.Text = "Delete";
            this.btnCashierdelete.UseVisualStyleBackColor = false;
            this.btnCashierdelete.Click += new System.EventHandler(this.btnCashierdelete_Click);
            // 
            // btnCashierupdate
            // 
            this.btnCashierupdate.BackColor = System.Drawing.Color.Black;
            this.btnCashierupdate.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierupdate.ForeColor = System.Drawing.Color.White;
            this.btnCashierupdate.Location = new System.Drawing.Point(221, 448);
            this.btnCashierupdate.Name = "btnCashierupdate";
            this.btnCashierupdate.Size = new System.Drawing.Size(108, 35);
            this.btnCashierupdate.TabIndex = 5;
            this.btnCashierupdate.Text = "Update";
            this.btnCashierupdate.UseVisualStyleBackColor = false;
            this.btnCashierupdate.Click += new System.EventHandler(this.btnCashierupdate_Click);
            // 
            // btnCashierdisplay
            // 
            this.btnCashierdisplay.BackColor = System.Drawing.Color.Black;
            this.btnCashierdisplay.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashierdisplay.ForeColor = System.Drawing.Color.White;
            this.btnCashierdisplay.Location = new System.Drawing.Point(86, 447);
            this.btnCashierdisplay.Name = "btnCashierdisplay";
            this.btnCashierdisplay.Size = new System.Drawing.Size(108, 35);
            this.btnCashierdisplay.TabIndex = 4;
            this.btnCashierdisplay.Text = "Display";
            this.btnCashierdisplay.UseVisualStyleBackColor = false;
            this.btnCashierdisplay.Click += new System.EventHandler(this.btnCashierdisplay_Click);
            // 
            // txtCashiersearch
            // 
            this.txtCashiersearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashiersearch.ForeColor = System.Drawing.Color.Black;
            this.txtCashiersearch.Location = new System.Drawing.Point(399, 24);
            this.txtCashiersearch.Multiline = true;
            this.txtCashiersearch.Name = "txtCashiersearch";
            this.txtCashiersearch.Size = new System.Drawing.Size(225, 31);
            this.txtCashiersearch.TabIndex = 9;
            this.txtCashiersearch.TextChanged += new System.EventHandler(this.txtCashiersearch_TextChanged);
            // 
            // btnCashiersearch
            // 
            this.btnCashiersearch.BackColor = System.Drawing.Color.Black;
            this.btnCashiersearch.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashiersearch.ForeColor = System.Drawing.Color.White;
            this.btnCashiersearch.Location = new System.Drawing.Point(630, 24);
            this.btnCashiersearch.Name = "btnCashiersearch";
            this.btnCashiersearch.Size = new System.Drawing.Size(139, 31);
            this.btnCashiersearch.TabIndex = 8;
            this.btnCashiersearch.Text = "Search";
            this.btnCashiersearch.UseVisualStyleBackColor = false;
            this.btnCashiersearch.Click += new System.EventHandler(this.btnCashiersearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvDisplay);
            this.panel2.Controls.Add(this.txtCashiersearch);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnCashiersearch);
            this.panel2.Controls.Add(this.btnCashierdelete);
            this.panel2.Controls.Add(this.btnCashierupdate);
            this.panel2.Controls.Add(this.btnCashierdisplay);
            this.panel2.Location = new System.Drawing.Point(477, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 506);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(502, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoGenerateColumns = false;
            this.dgvDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailaddressDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvDisplay.DataSource = this.cashierBindingSource;
            this.dgvDisplay.Location = new System.Drawing.Point(15, 61);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(745, 350);
            this.dgvDisplay.TabIndex = 10;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailaddressDataGridViewTextBoxColumn
            // 
            this.emailaddressDataGridViewTextBoxColumn.DataPropertyName = "email_address";
            this.emailaddressDataGridViewTextBoxColumn.HeaderText = "email_address";
            this.emailaddressDataGridViewTextBoxColumn.Name = "emailaddressDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "pass_word";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "pass_word";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "cashier";
            this.cashierBindingSource.DataSource = this.possystemDataSet1;
            // 
            // possystemDataSet1
            // 
            this.possystemDataSet1.DataSetName = "PossystemDataSet1";
            this.possystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Black;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel1.Location = new System.Drawing.Point(1225, -6);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(24, 25);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(1199, -18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 40);
            this.label9.TabIndex = 12;
            this.label9.Text = "-";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CashierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1261, 544);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierPage";
            this.Load += new System.EventHandler(this.CashierPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewCashier;
        private System.Windows.Forms.DateTimePicker dtpCashier;
        private System.Windows.Forms.TextBox txtCashierpassword;
        private System.Windows.Forms.TextBox txtCashierusername;
        private System.Windows.Forms.TextBox txtCashierlname;
        private System.Windows.Forms.TextBox txtCashierfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCashierdelete;
        private System.Windows.Forms.Button btnCashierupdate;
        private System.Windows.Forms.Button btnCashierdisplay;
        private System.Windows.Forms.TextBox txtCashiersearch;
        private System.Windows.Forms.Button btnCashiersearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private PossystemDataSet1 possystemDataSet1;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private PossystemDataSet1TableAdapters.cashierTableAdapter cashierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCashieremail;
        private System.Windows.Forms.TextBox txtCashiercontact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label9;
    }
}