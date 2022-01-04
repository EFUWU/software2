
namespace ATM
{
    partial class Deposit
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Accountnumlabel = new System.Windows.Forms.Label();
            this.NameShowlabel = new System.Windows.Forms.Label();
            this.AccountnumShowlabel = new System.Windows.Forms.Label();
            this.Amountlabel = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.resulttime_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmbtn = new ePOSOne.btnProduct.Button_WOC();
            this.Cancelbtn = new ePOSOne.btnProduct.Button_WOC();
            this.atmdataTableAdapter1 = new ATM.ATMDATADataSetTableAdapters.atmdataTableAdapter();
            this.ministatementTableTableAdapter1 = new ATM.ATMDATADataSetTableAdapters.ministatementTableTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "Deposite";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(79, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 52);
            this.panel1.TabIndex = 23;
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
            // Accountnumlabel
            // 
            this.Accountnumlabel.AutoSize = true;
            this.Accountnumlabel.Location = new System.Drawing.Point(17, 86);
            this.Accountnumlabel.Name = "Accountnumlabel";
            this.Accountnumlabel.Size = new System.Drawing.Size(154, 26);
            this.Accountnumlabel.TabIndex = 5;
            this.Accountnumlabel.Text = "Account Num :";
            // 
            // NameShowlabel
            // 
            this.NameShowlabel.AutoSize = true;
            this.NameShowlabel.Location = new System.Drawing.Point(103, 28);
            this.NameShowlabel.Name = "NameShowlabel";
            this.NameShowlabel.Size = new System.Drawing.Size(0, 26);
            this.NameShowlabel.TabIndex = 6;
            // 
            // AccountnumShowlabel
            // 
            this.AccountnumShowlabel.AutoSize = true;
            this.AccountnumShowlabel.Location = new System.Drawing.Point(177, 86);
            this.AccountnumShowlabel.Name = "AccountnumShowlabel";
            this.AccountnumShowlabel.Size = new System.Drawing.Size(0, 26);
            this.AccountnumShowlabel.TabIndex = 7;
            // 
            // Amountlabel
            // 
            this.Amountlabel.AutoSize = true;
            this.Amountlabel.Location = new System.Drawing.Point(168, 273);
            this.Amountlabel.Name = "Amountlabel";
            this.Amountlabel.Size = new System.Drawing.Size(89, 26);
            this.Amountlabel.TabIndex = 8;
            this.Amountlabel.Text = "Amount";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(383, 53);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(63, 24);
            this.time_label.TabIndex = 25;
            this.time_label.Text = "Time:";
            // 
            // resulttime_label
            // 
            this.resulttime_label.AutoSize = true;
            this.resulttime_label.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttime_label.Location = new System.Drawing.Point(452, 53);
            this.resulttime_label.Name = "resulttime_label";
            this.resulttime_label.Size = new System.Drawing.Size(0, 24);
            this.resulttime_label.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.resulttime_label);
            this.groupBox1.Controls.Add(this.Confirmbtn);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.Amountlabel);
            this.groupBox1.Controls.Add(this.AccountnumShowlabel);
            this.groupBox1.Controls.Add(this.NameShowlabel);
            this.groupBox1.Controls.Add(this.Accountnumlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 429);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(263, 267);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(234, 32);
            this.AmountBox.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 52);
            this.panel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Deposit";
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.BackColor = System.Drawing.Color.Transparent;
            this.Confirmbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Confirmbtn.ButtonColor = System.Drawing.Color.SeaGreen;
            this.Confirmbtn.FlatAppearance.BorderSize = 0;
            this.Confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbtn.Location = new System.Drawing.Point(78, 378);
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
            this.Cancelbtn.Location = new System.Drawing.Point(387, 378);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.OnHoverBorderColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Cancelbtn.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.Cancelbtn.Size = new System.Drawing.Size(244, 45);
            this.Cancelbtn.TabIndex = 18;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.TextColor = System.Drawing.Color.White;
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            this.Cancelbtn.Resize += new System.EventHandler(this.Cancelbtn_Resize);
            // 
            // atmdataTableAdapter1
            // 
            this.atmdataTableAdapter1.ClearBeforeFill = true;
            // 
            // ministatementTableTableAdapter1
            // 
            this.ministatementTableTableAdapter1.ClearBeforeFill = true;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(846, 535);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.Resize += new System.EventHandler(this.Deposit_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Accountnumlabel;
        private System.Windows.Forms.Label NameShowlabel;
        private System.Windows.Forms.Label AccountnumShowlabel;
        private System.Windows.Forms.Label Amountlabel;
        private ePOSOne.btnProduct.Button_WOC Cancelbtn;
        private System.Windows.Forms.Label time_label;
        private ePOSOne.btnProduct.Button_WOC Confirmbtn;
        private System.Windows.Forms.Label resulttime_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountBox;
        private ATMDATADataSetTableAdapters.atmdataTableAdapter atmdataTableAdapter1;
        private ATMDATADataSetTableAdapters.ministatementTableTableAdapter ministatementTableTableAdapter1;
    }
}