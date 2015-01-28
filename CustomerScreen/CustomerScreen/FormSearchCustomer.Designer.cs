namespace CustomerScreen
{
    partial class FormSearchCustomer
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
            this.LblSearchCustomer = new System.Windows.Forms.Label();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.BtnSearchCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSearchCustomer
            // 
            this.LblSearchCustomer.AutoSize = true;
            this.LblSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchCustomer.Location = new System.Drawing.Point(23, 22);
            this.LblSearchCustomer.Name = "LblSearchCustomer";
            this.LblSearchCustomer.Size = new System.Drawing.Size(185, 24);
            this.LblSearchCustomer.TabIndex = 0;
            this.LblSearchCustomer.Text = "Enter customer Data ";
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(27, 49);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(181, 20);
            this.TxtSearchCustomer.TabIndex = 1;
            // 
            // BtnSearchCustomer
            // 
            this.BtnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSearchCustomer.Location = new System.Drawing.Point(225, 40);
            this.BtnSearchCustomer.Name = "BtnSearchCustomer";
            this.BtnSearchCustomer.Size = new System.Drawing.Size(125, 33);
            this.BtnSearchCustomer.TabIndex = 2;
            this.BtnSearchCustomer.Text = "Search";
            this.BtnSearchCustomer.UseVisualStyleBackColor = true;
            this.BtnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 200);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSearchCustomer);
            this.Controls.Add(this.TxtSearchCustomer);
            this.Controls.Add(this.LblSearchCustomer);
            this.Name = "FormSearchCustomer";
            this.Text = "FormSearchCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSearchCustomer;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Button BtnSearchCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}