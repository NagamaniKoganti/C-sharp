namespace CustomerScreen
{
    partial class FormCustomer
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
            this.LblCustname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblCountryName = new System.Windows.Forms.Label();
            this.domainUpDowncountry = new System.Windows.Forms.DomainUpDown();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.LblHobbies = new System.Windows.Forms.Label();
            this.checkBoxRead = new System.Windows.Forms.CheckBox();
            this.checkBoxWriting = new System.Windows.Forms.CheckBox();
            this.checkBoxPainting = new System.Windows.Forms.CheckBox();
            this.radioButtonUnmarried = new System.Windows.Forms.RadioButton();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSex.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustname
            // 
            this.LblCustname.AutoSize = true;
            this.LblCustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustname.Location = new System.Drawing.Point(56, 37);
            this.LblCustname.Name = "LblCustname";
            this.LblCustname.Size = new System.Drawing.Size(162, 24);
            this.LblCustname.TabIndex = 0;
            this.LblCustname.Text = "Customer Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 1;
            // 
            // LblCountryName
            // 
            this.LblCountryName.AutoSize = true;
            this.LblCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCountryName.Location = new System.Drawing.Point(56, 95);
            this.LblCountryName.Name = "LblCountryName";
            this.LblCountryName.Size = new System.Drawing.Size(146, 24);
            this.LblCountryName.TabIndex = 2;
            this.LblCountryName.Text = "Country Name : ";
            // 
            // domainUpDowncountry
            // 
            this.domainUpDowncountry.Items.Add("India");
            this.domainUpDowncountry.Items.Add("UK");
            this.domainUpDowncountry.Items.Add("USA");
            this.domainUpDowncountry.Items.Add("Malyasia");
            this.domainUpDowncountry.Location = new System.Drawing.Point(245, 101);
            this.domainUpDowncountry.Name = "domainUpDowncountry";
            this.domainUpDowncountry.Size = new System.Drawing.Size(120, 20);
            this.domainUpDowncountry.TabIndex = 3;
            this.domainUpDowncountry.Text = "Select Country";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(23, 19);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(23, 51);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // LblHobbies
            // 
            this.LblHobbies.AutoSize = true;
            this.LblHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHobbies.Location = new System.Drawing.Point(56, 240);
            this.LblHobbies.Name = "LblHobbies";
            this.LblHobbies.Size = new System.Drawing.Size(96, 24);
            this.LblHobbies.TabIndex = 7;
            this.LblHobbies.Text = "Hobbies : ";
            // 
            // checkBoxRead
            // 
            this.checkBoxRead.AutoSize = true;
            this.checkBoxRead.Location = new System.Drawing.Point(175, 247);
            this.checkBoxRead.Name = "checkBoxRead";
            this.checkBoxRead.Size = new System.Drawing.Size(66, 17);
            this.checkBoxRead.TabIndex = 8;
            this.checkBoxRead.Text = "Reading";
            this.checkBoxRead.UseVisualStyleBackColor = true;
            // 
            // checkBoxWriting
            // 
            this.checkBoxWriting.AutoSize = true;
            this.checkBoxWriting.Location = new System.Drawing.Point(247, 247);
            this.checkBoxWriting.Name = "checkBoxWriting";
            this.checkBoxWriting.Size = new System.Drawing.Size(59, 17);
            this.checkBoxWriting.TabIndex = 9;
            this.checkBoxWriting.Text = "Writing";
            this.checkBoxWriting.UseVisualStyleBackColor = true;
            // 
            // checkBoxPainting
            // 
            this.checkBoxPainting.AutoSize = true;
            this.checkBoxPainting.Location = new System.Drawing.Point(312, 247);
            this.checkBoxPainting.Name = "checkBoxPainting";
            this.checkBoxPainting.Size = new System.Drawing.Size(64, 17);
            this.checkBoxPainting.TabIndex = 10;
            this.checkBoxPainting.Text = "Painting";
            this.checkBoxPainting.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnmarried
            // 
            this.radioButtonUnmarried.AutoSize = true;
            this.radioButtonUnmarried.Location = new System.Drawing.Point(23, 60);
            this.radioButtonUnmarried.Name = "radioButtonUnmarried";
            this.radioButtonUnmarried.Size = new System.Drawing.Size(73, 17);
            this.radioButtonUnmarried.TabIndex = 13;
            this.radioButtonUnmarried.TabStop = true;
            this.radioButtonUnmarried.Text = "Unmarried";
            this.radioButtonUnmarried.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(23, 37);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMarried.TabIndex = 12;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Married";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            this.radioButtonMarried.CheckedChanged += new System.EventHandler(this.radioButtonMarried_CheckedChanged);
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.radioButtonMale);
            this.groupBoxSex.Controls.Add(this.radioButtonFemale);
            this.groupBoxSex.Location = new System.Drawing.Point(67, 137);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSex.TabIndex = 14;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Sex : ";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioButtonUnmarried);
            this.groupBoxStatus.Controls.Add(this.radioButtonMarried);
            this.groupBoxStatus.Location = new System.Drawing.Point(60, 288);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(200, 100);
            this.groupBoxStatus.TabIndex = 7;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.Location = new System.Drawing.Point(12, 415);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(174, 40);
            this.BtnAddCustomer.TabIndex = 16;
            this.BtnAddCustomer.Text = "Delete Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 402);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.checkBoxPainting);
            this.Controls.Add(this.checkBoxWriting);
            this.Controls.Add(this.checkBoxRead);
            this.Controls.Add(this.LblHobbies);
            this.Controls.Add(this.domainUpDowncountry);
            this.Controls.Add(this.LblCountryName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblCustname);
            this.Name = "FormCustomer";
            this.Text = "Customer Entry";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblCountryName;
        private System.Windows.Forms.DomainUpDown domainUpDowncountry;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Label LblHobbies;
        private System.Windows.Forms.CheckBox checkBoxRead;
        private System.Windows.Forms.CheckBox checkBoxWriting;
        private System.Windows.Forms.CheckBox checkBoxPainting;
        private System.Windows.Forms.RadioButton radioButtonUnmarried;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

