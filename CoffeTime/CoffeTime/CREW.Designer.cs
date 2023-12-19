namespace CoffeTime
{
    partial class CREW
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
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.dgvCoffee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStocks
            // 
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(192, 118);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.RowHeadersWidth = 62;
            this.dgvStocks.RowTemplate.Height = 28;
            this.dgvStocks.Size = new System.Drawing.Size(423, 195);
            this.dgvStocks.TabIndex = 55;
            this.dgvStocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellClick);
            // 
            // dgvCoffee
            // 
            this.dgvCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoffee.Location = new System.Drawing.Point(87, 386);
            this.dgvCoffee.Name = "dgvCoffee";
            this.dgvCoffee.RowHeadersWidth = 62;
            this.dgvCoffee.RowTemplate.Height = 28;
            this.dgvCoffee.Size = new System.Drawing.Size(618, 239);
            this.dgvCoffee.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 74);
            this.label1.TabIndex = 57;
            this.label1.Text = "Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 49);
            this.label2.TabIndex = 58;
            this.label2.Text = "Sales OF Coffee";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(25, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 20);
            this.linkLabel1.TabIndex = 59;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Coffee House";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(25, 95);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 20);
            this.linkLabel2.TabIndex = 60;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Logout";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // CREW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(797, 647);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCoffee);
            this.Controls.Add(this.dgvStocks);
            this.Name = "CREW";
            this.Text = "Manages";
            this.Load += new System.EventHandler(this.CREW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.DataGridView dgvCoffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}