namespace Pointofsales1
{
    partial class Sales
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
            this.label14 = new System.Windows.Forms.Label();
            this.TimeTextBox1 = new System.Windows.Forms.Label();
            this.DateTextBox1 = new System.Windows.Forms.Label();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnsalessearch = new System.Windows.Forms.Button();
            this.txtsalessearch = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtsalesid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txtsalesdescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsalesqty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsalesproduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsalesamount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsalesprice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsalestotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtsaleschange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsalesclear = new System.Windows.Forms.Button();
            this.txtsalescash = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtsalesvat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saleslistview = new System.Windows.Forms.ListView();
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewamount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TimeTextBox1);
            this.panel1.Controls.Add(this.DateTextBox1);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.btnsalessearch);
            this.panel1.Controls.Add(this.txtsalessearch);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.txtsalesid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 101);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 35);
            this.label14.TabIndex = 23;
            this.label14.Text = "Cashier";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // TimeTextBox1
            // 
            this.TimeTextBox1.AutoSize = true;
            this.TimeTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTextBox1.ForeColor = System.Drawing.Color.Black;
            this.TimeTextBox1.Location = new System.Drawing.Point(488, 72);
            this.TimeTextBox1.Name = "TimeTextBox1";
            this.TimeTextBox1.Size = new System.Drawing.Size(39, 17);
            this.TimeTextBox1.TabIndex = 22;
            this.TimeTextBox1.Text = "Time";
            // 
            // DateTextBox1
            // 
            this.DateTextBox1.AutoSize = true;
            this.DateTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox1.ForeColor = System.Drawing.Color.Black;
            this.DateTextBox1.Location = new System.Drawing.Point(406, 72);
            this.DateTextBox1.Name = "DateTextBox1";
            this.DateTextBox1.Size = new System.Drawing.Size(38, 17);
            this.DateTextBox1.TabIndex = 21;
            this.DateTextBox1.Text = "Date";
            this.DateTextBox1.Click += new System.EventHandler(this.DateTextBox1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(127, 54);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "gunaLabel3";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // btnsalessearch
            // 
            this.btnsalessearch.BackColor = System.Drawing.Color.Black;
            this.btnsalessearch.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalessearch.ForeColor = System.Drawing.Color.White;
            this.btnsalessearch.Location = new System.Drawing.Point(318, 13);
            this.btnsalessearch.Name = "btnsalessearch";
            this.btnsalessearch.Size = new System.Drawing.Size(103, 27);
            this.btnsalessearch.TabIndex = 19;
            this.btnsalessearch.Text = "Search";
            this.btnsalessearch.UseVisualStyleBackColor = false;
            // 
            // txtsalessearch
            // 
            this.txtsalessearch.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalessearch.ForeColor = System.Drawing.Color.Black;
            this.txtsalessearch.Location = new System.Drawing.Point(427, 13);
            this.txtsalessearch.Multiline = true;
            this.txtsalessearch.Name = "txtsalessearch";
            this.txtsalessearch.Size = new System.Drawing.Size(206, 27);
            this.txtsalessearch.TabIndex = 16;
            this.txtsalessearch.TextChanged += new System.EventHandler(this.txtsalessearch_TextChanged);
            // 
            // txtbarcode
            // 
            this.txtbarcode.ForeColor = System.Drawing.Color.Black;
            this.txtbarcode.Location = new System.Drawing.Point(710, 13);
            this.txtbarcode.Multiline = true;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(144, 27);
            this.txtbarcode.TabIndex = 18;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // txtsalesid
            // 
            this.txtsalesid.BackColor = System.Drawing.Color.White;
            this.txtsalesid.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesid.Location = new System.Drawing.Point(98, 69);
            this.txtsalesid.Multiline = true;
            this.txtsalesid.Name = "txtsalesid";
            this.txtsalesid.ReadOnly = true;
            this.txtsalesid.Size = new System.Drawing.Size(200, 27);
            this.txtsalesid.TabIndex = 5;
            this.txtsalesid.TextChanged += new System.EventHandler(this.txtsalesid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(644, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES ID :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtsalesdescription);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtsalesqty);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtsalesproduct);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtsalesamount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtsalesprice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(866, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 545);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(79, 492);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtsalesdescription
            // 
            this.txtsalesdescription.ForeColor = System.Drawing.Color.Black;
            this.txtsalesdescription.Location = new System.Drawing.Point(79, 335);
            this.txtsalesdescription.Multiline = true;
            this.txtsalesdescription.Name = "txtsalesdescription";
            this.txtsalesdescription.Size = new System.Drawing.Size(198, 136);
            this.txtsalesdescription.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(16, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Description";
            // 
            // txtsalesqty
            // 
            this.txtsalesqty.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesqty.ForeColor = System.Drawing.Color.Black;
            this.txtsalesqty.Location = new System.Drawing.Point(79, 264);
            this.txtsalesqty.Multiline = true;
            this.txtsalesqty.Name = "txtsalesqty";
            this.txtsalesqty.Size = new System.Drawing.Size(198, 36);
            this.txtsalesqty.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(17, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Quantity";
            // 
            // txtsalesproduct
            // 
            this.txtsalesproduct.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesproduct.ForeColor = System.Drawing.Color.Black;
            this.txtsalesproduct.Location = new System.Drawing.Point(79, 37);
            this.txtsalesproduct.Multiline = true;
            this.txtsalesproduct.Name = "txtsalesproduct";
            this.txtsalesproduct.ReadOnly = true;
            this.txtsalesproduct.Size = new System.Drawing.Size(198, 31);
            this.txtsalesproduct.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Amount";
            // 
            // txtsalesamount
            // 
            this.txtsalesamount.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesamount.ForeColor = System.Drawing.Color.Black;
            this.txtsalesamount.Location = new System.Drawing.Point(79, 192);
            this.txtsalesamount.Multiline = true;
            this.txtsalesamount.Name = "txtsalesamount";
            this.txtsalesamount.ReadOnly = true;
            this.txtsalesamount.Size = new System.Drawing.Size(198, 38);
            this.txtsalesamount.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price";
            // 
            // txtsalesprice
            // 
            this.txtsalesprice.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesprice.ForeColor = System.Drawing.Color.Black;
            this.txtsalesprice.Location = new System.Drawing.Point(79, 107);
            this.txtsalesprice.Multiline = true;
            this.txtsalesprice.Name = "txtsalesprice";
            this.txtsalesprice.ReadOnly = true;
            this.txtsalesprice.Size = new System.Drawing.Size(198, 35);
            this.txtsalesprice.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.txtsalestotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(2, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 83);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(625, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 44);
            this.button3.TabIndex = 18;
            this.button3.Text = "Check Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtsalestotal
            // 
            this.txtsalestotal.BackColor = System.Drawing.Color.White;
            this.txtsalestotal.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalestotal.ForeColor = System.Drawing.Color.Black;
            this.txtsalestotal.Location = new System.Drawing.Point(197, 17);
            this.txtsalestotal.Multiline = true;
            this.txtsalestotal.Name = "txtsalestotal";
            this.txtsalestotal.ReadOnly = true;
            this.txtsalestotal.Size = new System.Drawing.Size(247, 49);
            this.txtsalestotal.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 65);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtsaleschange);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnsalesclear);
            this.panel4.Controls.Add(this.txtsalescash);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.txtsalesvat);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(609, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 349);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtsaleschange
            // 
            this.txtsaleschange.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaleschange.ForeColor = System.Drawing.Color.Black;
            this.txtsaleschange.Location = new System.Drawing.Point(13, 154);
            this.txtsaleschange.Multiline = true;
            this.txtsaleschange.Name = "txtsaleschange";
            this.txtsaleschange.Size = new System.Drawing.Size(222, 36);
            this.txtsaleschange.TabIndex = 15;
            this.txtsaleschange.TextChanged += new System.EventHandler(this.txtsaleschange_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "VAT";
            // 
            // btnsalesclear
            // 
            this.btnsalesclear.BackColor = System.Drawing.Color.Black;
            this.btnsalesclear.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalesclear.ForeColor = System.Drawing.Color.White;
            this.btnsalesclear.Location = new System.Drawing.Point(18, 305);
            this.btnsalesclear.Name = "btnsalesclear";
            this.btnsalesclear.Size = new System.Drawing.Size(217, 35);
            this.btnsalesclear.TabIndex = 7;
            this.btnsalesclear.Text = "Clear";
            this.btnsalesclear.UseVisualStyleBackColor = false;
            this.btnsalesclear.Click += new System.EventHandler(this.btnsalesclear_Click);
            // 
            // txtsalescash
            // 
            this.txtsalescash.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalescash.ForeColor = System.Drawing.Color.Black;
            this.txtsalescash.Location = new System.Drawing.Point(13, 85);
            this.txtsalescash.Multiline = true;
            this.txtsalescash.Name = "txtsalescash";
            this.txtsalescash.Size = new System.Drawing.Size(222, 38);
            this.txtsalescash.TabIndex = 13;
            this.txtsalescash.TextChanged += new System.EventHandler(this.txtsalescash_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtsalesvat
            // 
            this.txtsalesvat.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesvat.ForeColor = System.Drawing.Color.Black;
            this.txtsalesvat.Location = new System.Drawing.Point(13, 31);
            this.txtsalesvat.Multiline = true;
            this.txtsalesvat.Name = "txtsalesvat";
            this.txtsalesvat.Size = new System.Drawing.Size(222, 33);
            this.txtsalesvat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "CASH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "CHANGE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saleslistview
            // 
            this.saleslistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saleslistview.BackColor = System.Drawing.SystemColors.Window;
            this.saleslistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qty,
            this.productname,
            this.price,
            this.listviewamount});
            this.saleslistview.HideSelection = false;
            this.saleslistview.Location = new System.Drawing.Point(5, 140);
            this.saleslistview.Name = "saleslistview";
            this.saleslistview.Size = new System.Drawing.Size(595, 340);
            this.saleslistview.TabIndex = 4;
            this.saleslistview.UseCompatibleStateImageBehavior = false;
            this.saleslistview.View = System.Windows.Forms.View.Details;
            this.saleslistview.SelectedIndexChanged += new System.EventHandler(this.saleslistview_SelectedIndexChanged);
            // 
            // qty
            // 
            this.qty.Text = "qty";
            this.qty.Width = 100;
            // 
            // productname
            // 
            this.productname.Text = "productname";
            this.productname.Width = 250;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 130;
            // 
            // listviewamount
            // 
            this.listviewamount.Text = "amount";
            this.listviewamount.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(1119, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(1084, -7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 40);
            this.label15.TabIndex = 8;
            this.label15.Text = "-";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1155, 598);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.saleslistview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalessearch;
        private System.Windows.Forms.TextBox txtsalessearch;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtsalesid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsalesdescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsalesqty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsalesproduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsalesamount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsalesprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtsalestotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtsaleschange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalesclear;
        private System.Windows.Forms.TextBox txtsalescash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtsalesvat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView saleslistview;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader productname;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader listviewamount;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Label TimeTextBox1;
        private System.Windows.Forms.Label DateTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
    }
}