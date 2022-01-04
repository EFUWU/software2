namespace ATM
{
    partial class CurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyExchange));
            this.resulttime_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EGPradioButton = new System.Windows.Forms.RadioButton();
            this.EURradioButton = new System.Windows.Forms.RadioButton();
            this.USDradioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmbtn = new ePOSOne.btnProduct.Button_WOC();
            this.Cancelbtn = new ePOSOne.btnProduct.Button_WOC();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.AccountnumShowlabel = new System.Windows.Forms.Label();
            this.NameShowlabel = new System.Windows.Forms.Label();
            this.Accountnumlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.atmdataTableAdapter1 = new ATM.ATMDATADataSetTableAdapters.atmdataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resulttime_label
            // 
            this.resulttime_label.AutoSize = true;
            this.resulttime_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttime_label.Location = new System.Drawing.Point(479, 55);
            this.resulttime_label.Name = "resulttime_label";
            this.resulttime_label.Size = new System.Drawing.Size(0, 24);
            this.resulttime_label.TabIndex = 32;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(410, 55);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(63, 24);
            this.time_label.TabIndex = 31;
            this.time_label.Text = "Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 30);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EGP";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // EGPradioButton
            // 
            this.EGPradioButton.AutoSize = true;
            this.EGPradioButton.Location = new System.Drawing.Point(28, 90);
            this.EGPradioButton.Name = "EGPradioButton";
            this.EGPradioButton.Size = new System.Drawing.Size(68, 30);
            this.EGPradioButton.TabIndex = 25;
            this.EGPradioButton.TabStop = true;
            this.EGPradioButton.Text = "EGP";
            this.EGPradioButton.UseVisualStyleBackColor = true;
            // 
            // EURradioButton
            // 
            this.EURradioButton.AutoSize = true;
            this.EURradioButton.Location = new System.Drawing.Point(28, 53);
            this.EURradioButton.Name = "EURradioButton";
            this.EURradioButton.Size = new System.Drawing.Size(69, 30);
            this.EURradioButton.TabIndex = 24;
            this.EURradioButton.TabStop = true;
            this.EURradioButton.Text = "EUR";
            this.EURradioButton.UseVisualStyleBackColor = true;
            // 
            // USDradioButton
            // 
            this.USDradioButton.AutoSize = true;
            this.USDradioButton.Location = new System.Drawing.Point(28, 17);
            this.USDradioButton.Name = "USDradioButton";
            this.USDradioButton.Size = new System.Drawing.Size(71, 30);
            this.USDradioButton.TabIndex = 23;
            this.USDradioButton.TabStop = true;
            this.USDradioButton.Text = "USD";
            this.USDradioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 52);
            this.panel1.TabIndex = 22;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(176, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(275, 36);
            this.label.TabIndex = 20;
            this.label.Text = "Currency Exchange";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 20;
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.BackColor = System.Drawing.Color.Transparent;
            this.Confirmbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Confirmbtn.ButtonColor = System.Drawing.Color.SeaGreen;
            this.Confirmbtn.FlatAppearance.BorderSize = 0;
            this.Confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbtn.Location = new System.Drawing.Point(71, 411);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.OnHoverBorderColor = System.Drawing.Color.SeaGreen;
            this.Confirmbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Confirmbtn.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.Confirmbtn.Size = new System.Drawing.Size(244, 45);
            this.Confirmbtn.TabIndex = 19;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.TextColor = System.Drawing.Color.White;
            this.Confirmbtn.UseVisualStyleBackColor = false;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Cancelbtn.ButtonColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.FlatAppearance.BorderSize = 0;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Location = new System.Drawing.Point(380, 411);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Cancelbtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.Size = new System.Drawing.Size(244, 45);
            this.Cancelbtn.TabIndex = 18;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.TextColor = System.Drawing.Color.White;
            this.Cancelbtn.UseVisualStyleBackColor = false;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(120, 239);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(138, 32);
            this.AmountBox.TabIndex = 9;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Location = new System.Drawing.Point(9, 245);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(89, 26);
            this.Amountlabel.TabIndex = 8;
            this.Amountlabel.Text = "Amount";
            // 
            // AccountnumShowlabel
            // 
            this.AccountnumShowlabel.AutoSize = true;
            this.AccountnumShowlabel.Location = new System.Drawing.Point(177, 86);
            this.AccountnumShowlabel.Name = "AccountnumShowlabel";
            this.AccountnumShowlabel.Size = new System.Drawing.Size(0, 26);
            this.AccountnumShowlabel.TabIndex = 7;
            // 
            // NameShowlabel
            // 
            this.NameShowlabel.AutoSize = true;
            this.NameShowlabel.Location = new System.Drawing.Point(103, 28);
            this.NameShowlabel.Name = "NameShowlabel";
            this.NameShowlabel.Size = new System.Drawing.Size(0, 26);
            this.NameShowlabel.TabIndex = 6;
            // 
            // Accountnumlabel
            // 
            this.Accountnumlabel.AutoSize = true;
            this.Accountnumlabel.Location = new System.Drawing.Point(17, 86);
            this.Accountnumlabel.Name = "Accountnumlabel";
            this.Accountnumlabel.Size = new System.Drawing.Size(154, 26);
            this.Accountnumlabel.TabIndex = 5;
            this.Accountnumlabel.Text = "Account Num :";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(17, 28);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(80, 26);
            this.Namelabel.TabIndex = 4;
            this.Namelabel.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.resulttime_label);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Confirmbtn);
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.Amountlabel);
            this.groupBox1.Controls.Add(this.AccountnumShowlabel);
            this.groupBox1.Controls.Add(this.NameShowlabel);
            this.groupBox1.Controls.Add(this.Accountnumlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 484);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(38, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 30);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "USD";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(38, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 30);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EUR";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(445, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 134);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EGPradioButton);
            this.groupBox3.Controls.Add(this.EURradioButton);
            this.groupBox3.Controls.Add(this.USDradioButton);
            this.groupBox3.Location = new System.Drawing.Point(92, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 127);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // atmdataTableAdapter1
            // 
            this.atmdataTableAdapter1.ClearBeforeFill = true;
            // 
            // CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(832, 536);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CurrencyExchange";
            this.Load += new System.EventHandler(this.CurrencyExchange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label resulttime_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton EGPradioButton;
        private System.Windows.Forms.RadioButton EURradioButton;
        private System.Windows.Forms.RadioButton USDradioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC Confirmbtn;
        private ePOSOne.btnProduct.Button_WOC Cancelbtn;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label Amountlabel;
        private System.Windows.Forms.Label AccountnumShowlabel;
        private System.Windows.Forms.Label NameShowlabel;
        private System.Windows.Forms.Label Accountnumlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox3;
        private ATMDATADataSetTableAdapters.atmdataTableAdapter atmdataTableAdapter1;
    }
}