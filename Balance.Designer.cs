
namespace ATM
{
    partial class Balance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resulttime_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.balancelabel = new System.Windows.Forms.Label();
            this.Backbtn = new ePOSOne.btnProduct.Button_WOC();
            this.AccountnumShowlabel = new System.Windows.Forms.Label();
            this.NameShowlabel = new System.Windows.Forms.Label();
            this.Accountnumlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(72, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 52);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resulttime_label);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.balancelabel);
            this.groupBox1.Controls.Add(this.Backbtn);
            this.groupBox1.Controls.Add(this.AccountnumShowlabel);
            this.groupBox1.Controls.Add(this.NameShowlabel);
            this.groupBox1.Controls.Add(this.Accountnumlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 429);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Balance";
            // 
            // resulttime_label
            // 
            this.resulttime_label.AutoSize = true;
            this.resulttime_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttime_label.Location = new System.Drawing.Point(452, 55);
            this.resulttime_label.Name = "resulttime_label";
            this.resulttime_label.Size = new System.Drawing.Size(0, 24);
            this.resulttime_label.TabIndex = 26;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(383, 55);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(63, 24);
            this.time_label.TabIndex = 25;
            this.time_label.Text = "Time:";
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(329, 262);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(0, 26);
            this.balancelabel.TabIndex = 19;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Transparent;
            this.Backbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Backbtn.ButtonColor = System.Drawing.Color.Firebrick;
            this.Backbtn.FlatAppearance.BorderSize = 0;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(387, 378);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.Backbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Backbtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.Backbtn.Size = new System.Drawing.Size(244, 45);
            this.Backbtn.TabIndex = 18;
            this.Backbtn.Text = "Back";
            this.Backbtn.TextColor = System.Drawing.Color.White;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
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
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Balance";
            this.Resize += new System.EventHandler(this.Balance_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resulttime_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label balancelabel;
        private ePOSOne.btnProduct.Button_WOC Backbtn;
        private System.Windows.Forms.Label AccountnumShowlabel;
        private System.Windows.Forms.Label NameShowlabel;
        private System.Windows.Forms.Label Accountnumlabel;
        private System.Windows.Forms.Label Namelabel;
    }
}