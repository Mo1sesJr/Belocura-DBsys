namespace CoffeTime
{
    partial class ADMIN
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
            this.label4 = new System.Windows.Forms.Label();
            this.Coffee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbstock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Item Number";
            // 
            // Coffee
            // 
            this.Coffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee.FormattingEnabled = true;
            this.Coffee.Items.AddRange(new object[] {
            "Black",
            "Latte",
            "Cappuccino",
            "Americano",
            "Espresso",
            "Doppio"});
            this.Coffee.Location = new System.Drawing.Point(227, 115);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(197, 38);
            this.Coffee.TabIndex = 24;
            this.Coffee.SelectedIndexChanged += new System.EventHandler(this.item_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Coffee";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(466, 116);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 37);
            this.price.TabIndex = 26;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Price";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 28;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbstock
            // 
            this.tbstock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbstock.Location = new System.Drawing.Point(606, 116);
            this.tbstock.Name = "tbstock";
            this.tbstock.Size = new System.Drawing.Size(100, 37);
            this.tbstock.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Stock";
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(51, 112);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 37);
            this.tbNumber.TabIndex = 31;
            // 
            // dgvStocks
            // 
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(51, 254);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.RowHeadersWidth = 62;
            this.dgvStocks.RowTemplate.Height = 28;
            this.dgvStocks.Size = new System.Drawing.Size(691, 231);
            this.dgvStocks.TabIndex = 33;
            this.dgvStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellClick);
            this.dgvStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(319, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 46);
            this.button2.TabIndex = 41;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(149, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 50);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dgvStocks);
            this.panel1.Controls.Add(this.tbNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbstock);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Coffee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 532);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(124, 29);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(143, 23);
            this.linkLabel2.TabIndex = 47;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Coffee House";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(29, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 23);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 522);
            this.Controls.Add(this.panel1);
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.ADMIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Coffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbstock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}