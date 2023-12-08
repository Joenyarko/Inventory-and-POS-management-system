namespace Pointofsales1
{
    partial class Inventory
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
            this.inventorydgv = new System.Windows.Forms.DataGridView();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.possystemDataSet1 = new Pointofsales1.PossystemDataSet1();
            this.inventoryTableAdapter = new Pointofsales1.PossystemDataSet1TableAdapters.inventoryTableAdapter();
            this.btninvdisplay = new System.Windows.Forms.Button();
            this.btninvadd = new System.Windows.Forms.Button();
            this.btninvupt = new System.Windows.Forms.Button();
            this.btninvendel = new System.Windows.Forms.Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventorydgv
            // 
            this.inventorydgv.AutoGenerateColumns = false;
            this.inventorydgv.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.inventorydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorydgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qtyDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productcodeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.inventorydgv.DataSource = this.inventoryBindingSource;
            this.inventorydgv.GridColor = System.Drawing.Color.White;
            this.inventorydgv.Location = new System.Drawing.Point(23, 31);
            this.inventorydgv.Name = "inventorydgv";
            this.inventorydgv.Size = new System.Drawing.Size(543, 405);
            this.inventorydgv.TabIndex = 0;
            this.inventorydgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventorydgv_CellContentClick);
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productcodeDataGridViewTextBoxColumn
            // 
            this.productcodeDataGridViewTextBoxColumn.DataPropertyName = "productcode";
            this.productcodeDataGridViewTextBoxColumn.HeaderText = "productcode";
            this.productcodeDataGridViewTextBoxColumn.Name = "productcodeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.possystemDataSet1;
            // 
            // possystemDataSet1
            // 
            this.possystemDataSet1.DataSetName = "PossystemDataSet1";
            this.possystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // btninvdisplay
            // 
            this.btninvdisplay.BackColor = System.Drawing.Color.Black;
            this.btninvdisplay.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvdisplay.ForeColor = System.Drawing.Color.White;
            this.btninvdisplay.Location = new System.Drawing.Point(44, 442);
            this.btninvdisplay.Name = "btninvdisplay";
            this.btninvdisplay.Size = new System.Drawing.Size(87, 33);
            this.btninvdisplay.TabIndex = 1;
            this.btninvdisplay.Text = "Display";
            this.btninvdisplay.UseVisualStyleBackColor = false;
            this.btninvdisplay.Click += new System.EventHandler(this.btninvdisplay_Click);
            // 
            // btninvadd
            // 
            this.btninvadd.BackColor = System.Drawing.Color.Black;
            this.btninvadd.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvadd.ForeColor = System.Drawing.Color.White;
            this.btninvadd.Location = new System.Drawing.Point(166, 442);
            this.btninvadd.Name = "btninvadd";
            this.btninvadd.Size = new System.Drawing.Size(100, 33);
            this.btninvadd.TabIndex = 2;
            this.btninvadd.Text = "Add New";
            this.btninvadd.UseVisualStyleBackColor = false;
            this.btninvadd.Click += new System.EventHandler(this.btninvadd_Click);
            // 
            // btninvupt
            // 
            this.btninvupt.BackColor = System.Drawing.Color.Black;
            this.btninvupt.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvupt.ForeColor = System.Drawing.Color.White;
            this.btninvupt.Location = new System.Drawing.Point(320, 442);
            this.btninvupt.Name = "btninvupt";
            this.btninvupt.Size = new System.Drawing.Size(90, 33);
            this.btninvupt.TabIndex = 3;
            this.btninvupt.Text = "Update";
            this.btninvupt.UseVisualStyleBackColor = false;
            this.btninvupt.Click += new System.EventHandler(this.btninvupt_Click);
            // 
            // btninvendel
            // 
            this.btninvendel.BackColor = System.Drawing.Color.Black;
            this.btninvendel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvendel.ForeColor = System.Drawing.Color.White;
            this.btninvendel.Location = new System.Drawing.Point(451, 442);
            this.btninvendel.Name = "btninvendel";
            this.btninvendel.Size = new System.Drawing.Size(90, 33);
            this.btninvendel.TabIndex = 4;
            this.btninvendel.Text = "Delete";
            this.btninvendel.UseVisualStyleBackColor = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.gunaLabel1.Location = new System.Drawing.Point(543, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(23, 25);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "X";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(512, -9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 40);
            this.label15.TabIndex = 9;
            this.label15.Text = "-";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btninvendel);
            this.Controls.Add(this.btninvupt);
            this.Controls.Add(this.btninvadd);
            this.Controls.Add(this.btninvdisplay);
            this.Controls.Add(this.inventorydgv);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorydgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.possystemDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventorydgv;
        private PossystemDataSet1 possystemDataSet1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private PossystemDataSet1TableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btninvdisplay;
        private System.Windows.Forms.Button btninvadd;
        private System.Windows.Forms.Button btninvupt;
        private System.Windows.Forms.Button btninvendel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label15;
    }
}