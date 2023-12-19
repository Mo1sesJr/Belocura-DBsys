namespace CoffeTime
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbrslt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbp = new System.Windows.Forms.TextBox();
            this.rbgcash = new System.Windows.Forms.RadioButton();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbstock = new System.Windows.Forms.TextBox();
            this.Coffee = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CoffeeLevel = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dgvItem.Location = new System.Drawing.Point(20, 299);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 62;
            this.dgvItem.RowTemplate.Height = 28;
            this.dgvItem.Size = new System.Drawing.Size(618, 279);
            this.dgvItem.TabIndex = 55;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ItemNumber";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Coffee";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sugar%";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ModeofPayment";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mobile#";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbrslt);
            this.panel1.Location = new System.Drawing.Point(354, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 90);
            this.panel1.TabIndex = 51;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Payment";
            // 
            // tbrslt
            // 
            this.tbrslt.Location = new System.Drawing.Point(75, 41);
            this.tbrslt.Name = "tbrslt";
            this.tbrslt.Size = new System.Drawing.Size(100, 26);
            this.tbrslt.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(204, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 65);
            this.button2.TabIndex = 44;
            this.button2.Text = "Total";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Payment";
            // 
            // tbp
            // 
            this.tbp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp.Location = new System.Drawing.Point(187, 270);
            this.tbp.Name = "tbp";
            this.tbp.Size = new System.Drawing.Size(100, 37);
            this.tbp.TabIndex = 37;
            // 
            // rbgcash
            // 
            this.rbgcash.AutoSize = true;
            this.rbgcash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbgcash.Location = new System.Drawing.Point(55, 313);
            this.rbgcash.Name = "rbgcash";
            this.rbgcash.Size = new System.Drawing.Size(116, 34);
            this.rbgcash.TabIndex = 36;
            this.rbgcash.TabStop = true;
            this.rbgcash.Text = "Gcash";
            this.rbgcash.UseVisualStyleBackColor = true;
            this.rbgcash.CheckedChanged += new System.EventHandler(this.rbgcash_CheckedChanged);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.Location = new System.Drawing.Point(177, 313);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(97, 34);
            this.rbcash.TabIndex = 35;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "COD";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.CheckedChanged += new System.EventHandler(this.rbcash_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantity";
            // 
            // tbquantity
            // 
            this.tbquantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbquantity.Location = new System.Drawing.Point(220, 171);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(100, 37);
            this.tbquantity.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "#";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(1)))));
            this.panel3.Controls.Add(this.dgvItem);
            this.panel3.Controls.Add(this.dgvStocks);
            this.panel3.Location = new System.Drawing.Point(687, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 588);
            this.panel3.TabIndex = 62;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgvStocks
            // 
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(20, 20);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.RowHeadersWidth = 62;
            this.dgvStocks.RowTemplate.Height = 28;
            this.dgvStocks.Size = new System.Drawing.Size(618, 258);
            this.dgvStocks.TabIndex = 54;
            this.dgvStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stock";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 65);
            this.button1.TabIndex = 26;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Price";
            // 
            // tbprice
            // 
            this.tbprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbprice.Location = new System.Drawing.Point(42, 171);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 37);
            this.tbprice.TabIndex = 24;
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(88, 94);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 37);
            this.tbNumber.TabIndex = 29;
            // 
            // tbstock
            // 
            this.tbstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstock.Location = new System.Drawing.Point(429, 270);
            this.tbstock.Name = "tbstock";
            this.tbstock.Size = new System.Drawing.Size(109, 37);
            this.tbstock.TabIndex = 27;
            // 
            // Coffee
            // 
            this.Coffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee.Location = new System.Drawing.Point(235, 59);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(197, 37);
            this.Coffee.TabIndex = 21;
            this.Coffee.TextChanged += new System.EventHandler(this.Coffee_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.CoffeeLevel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbp);
            this.panel2.Controls.Add(this.rbgcash);
            this.panel2.Controls.Add(this.rbcash);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbquantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbprice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbNumber);
            this.panel2.Controls.Add(this.tbstock);
            this.panel2.Controls.Add(this.Coffee);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 590);
            this.panel2.TabIndex = 60;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 55;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 30);
            this.label9.TabIndex = 54;
            this.label9.Text = "Sugar level";
            // 
            // CoffeeLevel
            // 
            this.CoffeeLevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeLevel.FormattingEnabled = true;
            this.CoffeeLevel.Items.AddRange(new object[] {
            "10%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.CoffeeLevel.Location = new System.Drawing.Point(397, 169);
            this.CoffeeLevel.Name = "CoffeeLevel";
            this.CoffeeLevel.Size = new System.Drawing.Size(197, 38);
            this.CoffeeLevel.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.Mobile);
            this.panel4.Location = new System.Drawing.Point(48, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 90);
            this.panel4.TabIndex = 52;
            this.panel4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Number :";
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(94, 38);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(165, 26);
            this.Mobile.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Coffee Time!";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbrslt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbp;
        private System.Windows.Forms.RadioButton rbgcash;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbstock;
        private System.Windows.Forms.TextBox Coffee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CoffeeLevel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button3;
    }
}