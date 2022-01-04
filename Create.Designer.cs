
namespace ATM
{
    partial class Create
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
            this.dobdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Balancebox = new System.Windows.Forms.TextBox();
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.showcheckBox = new System.Windows.Forms.CheckBox();
            this.Cancelbtn = new ePOSOne.btnProduct.Button_WOC();
            this.Createbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.PINbox = new System.Windows.Forms.TextBox();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.Lastnamebox = new System.Windows.Forms.TextBox();
            this.Mobilenumbox = new System.Windows.Forms.TextBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.Accountnumbox = new System.Windows.Forms.TextBox();
            this.Firstnamebox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dobdateTimePicker
            // 
            this.dobdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobdateTimePicker.Location = new System.Drawing.Point(519, 217);
            this.dobdateTimePicker.Name = "dobdateTimePicker";
            this.dobdateTimePicker.Size = new System.Drawing.Size(138, 32);
            this.dobdateTimePicker.TabIndex = 22;
            // 
            // Balancebox
            // 
            this.Balancebox.ForeColor = System.Drawing.Color.Silver;
            this.Balancebox.Location = new System.Drawing.Point(16, 358);
            this.Balancebox.Name = "Balancebox";
            this.Balancebox.Size = new System.Drawing.Size(289, 32);
            this.Balancebox.TabIndex = 21;
            this.Balancebox.Text = "Balance";
            this.Balancebox.DoubleClick += new System.EventHandler(this.Balancebox_DoubleClick);
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.ForeColor = System.Drawing.Color.Silver;
            this.ConfirmBox.Location = new System.Drawing.Point(375, 423);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(289, 32);
            this.ConfirmBox.TabIndex = 19;
            this.ConfirmBox.Text = "Confirm";
            this.ConfirmBox.DoubleClick += new System.EventHandler(this.ConfirmBox_DoubleClick);
            // 
            // showcheckBox
            // 
            this.showcheckBox.AutoSize = true;
            this.showcheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcheckBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.showcheckBox.Location = new System.Drawing.Point(16, 461);
            this.showcheckBox.Name = "showcheckBox";
            this.showcheckBox.Size = new System.Drawing.Size(132, 23);
            this.showcheckBox.TabIndex = 18;
            this.showcheckBox.Text = "Show Password";
            this.showcheckBox.UseVisualStyleBackColor = true;
            this.showcheckBox.CheckedChanged += new System.EventHandler(this.showcheckBox_CheckedChanged);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.ButtonColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.FlatAppearance.BorderSize = 0;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Location = new System.Drawing.Point(394, 602);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Cancelbtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.Size = new System.Drawing.Size(244, 45);
            this.Cancelbtn.TabIndex = 17;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.TextColor = System.Drawing.Color.White;
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Createbtn
            // 
            this.Createbtn.BackColor = System.Drawing.Color.Transparent;
            this.Createbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Createbtn.ButtonColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.FlatAppearance.BorderSize = 0;
            this.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createbtn.Location = new System.Drawing.Point(35, 602);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.OnHoverBorderColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Createbtn.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.Createbtn.Size = new System.Drawing.Size(244, 45);
            this.Createbtn.TabIndex = 1;
            this.Createbtn.Text = "Create";
            this.Createbtn.TextColor = System.Drawing.Color.White;
            this.Createbtn.UseVisualStyleBackColor = false;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 50);
            this.label2.TabIndex = 14;
            this.label2.Text = "Creat Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender";
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GendercomboBox.ForeColor = System.Drawing.Color.Black;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GendercomboBox.Location = new System.Drawing.Point(457, 358);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(207, 34);
            this.GendercomboBox.TabIndex = 12;
            // 
            // PINbox
            // 
            this.PINbox.ForeColor = System.Drawing.Color.Silver;
            this.PINbox.Location = new System.Drawing.Point(16, 423);
            this.PINbox.Name = "PINbox";
            this.PINbox.Size = new System.Drawing.Size(289, 32);
            this.PINbox.TabIndex = 7;
            this.PINbox.Text = "PIN";
            this.PINbox.DoubleClick += new System.EventHandler(this.PINbox_DoubleClick);
            // 
            // Emailbox
            // 
            this.Emailbox.ForeColor = System.Drawing.Color.Silver;
            this.Emailbox.Location = new System.Drawing.Point(16, 498);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(648, 32);
            this.Emailbox.TabIndex = 9;
            this.Emailbox.Text = "Email";
            this.Emailbox.DoubleClick += new System.EventHandler(this.Emailbox_DoubleClick);
            // 
            // Lastnamebox
            // 
            this.Lastnamebox.ForeColor = System.Drawing.Color.Silver;
            this.Lastnamebox.Location = new System.Drawing.Point(375, 150);
            this.Lastnamebox.Name = "Lastnamebox";
            this.Lastnamebox.Size = new System.Drawing.Size(289, 32);
            this.Lastnamebox.TabIndex = 2;
            this.Lastnamebox.Text = "Last Name";
            this.Lastnamebox.DoubleClick += new System.EventHandler(this.Lastnamebox_DoubleClick);
            // 
            // Mobilenumbox
            // 
            this.Mobilenumbox.ForeColor = System.Drawing.Color.Silver;
            this.Mobilenumbox.Location = new System.Drawing.Point(16, 217);
            this.Mobilenumbox.Name = "Mobilenumbox";
            this.Mobilenumbox.Size = new System.Drawing.Size(289, 32);
            this.Mobilenumbox.TabIndex = 3;
            this.Mobilenumbox.Text = "Mobile Number";
            this.Mobilenumbox.DoubleClick += new System.EventHandler(this.Mobilenumbox_DoubleClick);
            // 
            // Addressbox
            // 
            this.Addressbox.ForeColor = System.Drawing.Color.Silver;
            this.Addressbox.Location = new System.Drawing.Point(16, 287);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(289, 32);
            this.Addressbox.TabIndex = 4;
            this.Addressbox.Text = "Address";
            this.Addressbox.DoubleClick += new System.EventHandler(this.Addressbox_DoubleClick);
            // 
            // Accountnumbox
            // 
            this.Accountnumbox.ForeColor = System.Drawing.Color.Silver;
            this.Accountnumbox.Location = new System.Drawing.Point(375, 287);
            this.Accountnumbox.Name = "Accountnumbox";
            this.Accountnumbox.Size = new System.Drawing.Size(289, 32);
            this.Accountnumbox.TabIndex = 5;
            this.Accountnumbox.Text = "Account Number";
            this.Accountnumbox.DoubleClick += new System.EventHandler(this.Accountnumbox_DoubleClick);
            // 
            // Firstnamebox
            // 
            this.Firstnamebox.ForeColor = System.Drawing.Color.Silver;
            this.Firstnamebox.Location = new System.Drawing.Point(16, 150);
            this.Firstnamebox.Name = "Firstnamebox";
            this.Firstnamebox.Size = new System.Drawing.Size(289, 32);
            this.Firstnamebox.TabIndex = 1;
            this.Firstnamebox.Text = "First Name";
            this.Firstnamebox.DoubleClick += new System.EventHandler(this.Firstnamebox_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dobdateTimePicker);
            this.groupBox1.Controls.Add(this.Balancebox);
            this.groupBox1.Controls.Add(this.ConfirmBox);
            this.groupBox1.Controls.Add(this.showcheckBox);
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.Createbtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GendercomboBox);
            this.groupBox1.Controls.Add(this.PINbox);
            this.groupBox1.Controls.Add(this.Emailbox);
            this.groupBox1.Controls.Add(this.Lastnamebox);
            this.groupBox1.Controls.Add(this.Mobilenumbox);
            this.groupBox1.Controls.Add(this.Addressbox);
            this.groupBox1.Controls.Add(this.Accountnumbox);
            this.groupBox1.Controls.Add(this.Firstnamebox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(239, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 686);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data OF Birth";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1170, 747);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.Resize += new System.EventHandler(this.Create_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dobdateTimePicker;
        private System.Windows.Forms.TextBox Balancebox;
        private System.Windows.Forms.TextBox ConfirmBox;
        private System.Windows.Forms.CheckBox showcheckBox;
        private ePOSOne.btnProduct.Button_WOC Cancelbtn;
        private ePOSOne.btnProduct.Button_WOC Createbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.TextBox PINbox;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.TextBox Lastnamebox;
        private System.Windows.Forms.TextBox Mobilenumbox;
        private System.Windows.Forms.TextBox Addressbox;
        private System.Windows.Forms.TextBox Accountnumbox;
        private System.Windows.Forms.TextBox Firstnamebox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}