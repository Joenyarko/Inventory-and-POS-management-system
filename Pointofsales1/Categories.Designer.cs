namespace Pointofsales1
{
    partial class Categories
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
            this.button2 = new System.Windows.Forms.Button();
            this.btncatsearch = new System.Windows.Forms.Button();
            this.txtcatsearch = new System.Windows.Forms.TextBox();
            this.txtcatdescrip = new System.Windows.Forms.TextBox();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.txtcatid = new System.Windows.Forms.TextBox();
            this.btncatdel = new System.Windows.Forms.Button();
            this.btncatupt = new System.Windows.Forms.Button();
            this.btncatadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvcat = new System.Windows.Forms.DataGridView();
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possystemDataSet2 = new Pointofsales1.PossystemDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new Pointofsales1.PossystemDataSet2TableAdapters.categoryTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btncatsearch);
            this.panel2.Controls.Add(this.txtcatsearch);
            this.panel2.Controls.Add(this.txtcatdescrip);
            this.panel2.Controls.Add(this.txtcatname);
            this.panel2.Controls.Add(this.txtcatid);
            this.panel2.Controls.Add(this.btncatdel);
            this.panel2.Controls.Add(this.btncatupt);
            this.panel2.Controls.Add(this.btncatadd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvcat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 317);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(41, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncatsearch
            // 
            this.btncatsearch.BackColor = System.Drawing.Color.Black;
            this.btncatsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatsearch.ForeColor = System.Drawing.Color.White;
            this.btncatsearch.Location = new System.Drawing.Point(508, 3);
            this.btncatsearch.Name = "btncatsearch";
            this.btncatsearch.Size = new System.Drawing.Size(93, 32);
            this.btncatsearch.TabIndex = 12;
            this.btncatsearch.Text = "SEARCH";
            this.btncatsearch.UseVisualStyleBackColor = false;
            this.btncatsearch.Click += new System.EventHandler(this.btncatsearch_Click);
            // 
            // txtcatsearch
            // 
            this.txtcatsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatsearch.ForeColor = System.Drawing.Color.Black;
            this.txtcatsearch.Location = new System.Drawing.Point(250, 3);
            this.txtcatsearch.Multiline = true;
            this.txtcatsearch.Name = "txtcatsearch";
            this.txtcatsearch.Size = new System.Drawing.Size(252, 32);
            this.txtcatsearch.TabIndex = 11;
            this.txtcatsearch.TextChanged += new System.EventHandler(this.txtcatsearch_TextChanged);
            // 
            // txtcatdescrip
            // 
            this.txtcatdescrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatdescrip.ForeColor = System.Drawing.Color.Black;
            this.txtcatdescrip.Location = new System.Drawing.Point(32, 155);
            this.txtcatdescrip.Multiline = true;
            this.txtcatdescrip.Name = "txtcatdescrip";
            this.txtcatdescrip.Size = new System.Drawing.Size(196, 81);
            this.txtcatdescrip.TabIndex = 10;
            // 
            // txtcatname
            // 
            this.txtcatname.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatname.ForeColor = System.Drawing.Color.Black;
            this.txtcatname.Location = new System.Drawing.Point(31, 95);
            this.txtcatname.Multiline = true;
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(197, 32);
            this.txtcatname.TabIndex = 9;
            // 
            // txtcatid
            // 
            this.txtcatid.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatid.ForeColor = System.Drawing.Color.Black;
            this.txtcatid.Location = new System.Drawing.Point(31, 38);
            this.txtcatid.Multiline = true;
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.ReadOnly = true;
            this.txtcatid.Size = new System.Drawing.Size(197, 30);
            this.txtcatid.TabIndex = 8;
            // 
            // btncatdel
            // 
            this.btncatdel.BackColor = System.Drawing.Color.Black;
            this.btncatdel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatdel.ForeColor = System.Drawing.Color.White;
            this.btncatdel.Location = new System.Drawing.Point(303, 271);
            this.btncatdel.Name = "btncatdel";
            this.btncatdel.Size = new System.Drawing.Size(80, 32);
            this.btncatdel.TabIndex = 7;
            this.btncatdel.Text = "Delete";
            this.btncatdel.UseVisualStyleBackColor = false;
            this.btncatdel.Click += new System.EventHandler(this.btncatdel_Click);
            // 
            // btncatupt
            // 
            this.btncatupt.BackColor = System.Drawing.Color.Black;
            this.btncatupt.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatupt.ForeColor = System.Drawing.Color.White;
            this.btncatupt.Location = new System.Drawing.Point(217, 271);
            this.btncatupt.Name = "btncatupt";
            this.btncatupt.Size = new System.Drawing.Size(80, 32);
            this.btncatupt.TabIndex = 6;
            this.btncatupt.Text = "Update";
            this.btncatupt.UseVisualStyleBackColor = false;
            this.btncatupt.Click += new System.EventHandler(this.btncatupt_Click);
            // 
            // btncatadd
            // 
            this.btncatadd.BackColor = System.Drawing.Color.Black;
            this.btncatadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatadd.ForeColor = System.Drawing.Color.White;
            this.btncatadd.Location = new System.Drawing.Point(131, 271);
            this.btncatadd.Name = "btncatadd";
            this.btncatadd.Size = new System.Drawing.Size(80, 32);
            this.btncatadd.TabIndex = 5;
            this.btncatadd.Text = "Add";
            this.btncatadd.UseVisualStyleBackColor = false;
            this.btncatadd.Click += new System.EventHandler(this.btncatadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "DESCRIPTION";
            // 
            // dgvcat
            // 
            this.dgvcat.AutoGenerateColumns = false;
            this.dgvcat.BackgroundColor = System.Drawing.Color.White;
            this.dgvcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catidDataGridViewTextBoxColumn,
            this.catnameDataGridViewTextBoxColumn,
            this.catdescDataGridViewTextBoxColumn});
            this.dgvcat.DataSource = this.categoryBindingSource;
            this.dgvcat.Location = new System.Drawing.Point(250, 38);
            this.dgvcat.Name = "dgvcat";
            this.dgvcat.Size = new System.Drawing.Size(351, 198);
            this.dgvcat.TabIndex = 3;
            this.dgvcat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcat_CellContentClick);
            // 
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "catid";
            this.catidDataGridViewTextBoxColumn.HeaderText = "catid";
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            this.catidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catnameDataGridViewTextBoxColumn
            // 
            this.catnameDataGridViewTextBoxColumn.DataPropertyName = "catname";
            this.catnameDataGridViewTextBoxColumn.HeaderText = "catname";
            this.catnameDataGridViewTextBoxColumn.Name = "catnameDataGridViewTextBoxColumn";
            // 
            // catdescDataGridViewTextBoxColumn
            // 
            this.catdescDataGridViewTextBoxColumn.DataPropertyName = "catdesc";
            this.catdescDataGridViewTextBoxColumn.HeaderText = "catdesc";
            this.catdescDataGridViewTextBoxColumn.Name = "catdescDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.possystemDataSet2BindingSource;
            // 
            // possystemDataSet2BindingSource
            // 
            this.possystemDataSet2BindingSource.DataSource = this.possystemDataSet2;
            this.possystemDataSet2BindingSource.Position = 0;
            // 
            // possystemDataSet2
            // 
            this.possystemDataSet2.DataSetName = "PossystemDataSet2";
            this.possystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(589, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(566, -13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 40);
            this.label15.TabIndex = 9;
            this.label15.Text = "-";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 438);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_form";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncatdel;
        private System.Windows.Forms.Button btncatupt;
        private System.Windows.Forms.Button btncatadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvcat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcatdescrip;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.TextBox txtcatid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncatsearch;
        private System.Windows.Forms.TextBox txtcatsearch;
        private System.Windows.Forms.BindingSource possystemDataSet2BindingSource;
        private PossystemDataSet2 possystemDataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private PossystemDataSet2TableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
    }
}