
namespace ATM
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.PINbox = new System.Windows.Forms.TextBox();
            this.AccountNumbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Creatbtn = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.Creatbtn);
            this.groupBox1.Controls.Add(this.PINbox);
            this.groupBox1.Controls.Add(this.AccountNumbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.BackColor = System.Drawing.Color.Transparent;
            this.show.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.Gray;
            this.show.Location = new System.Drawing.Point(44, 243);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(121, 21);
            this.show.TabIndex = 5;
            this.show.Text = "show password";
            this.show.UseVisualStyleBackColor = false;
            this.show.CheckedChanged += new System.EventHandler(this.show_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Transparent;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(44, 279);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(234, 35);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // PINbox
            // 
            this.PINbox.ForeColor = System.Drawing.Color.Silver;
            this.PINbox.Location = new System.Drawing.Point(44, 205);
            this.PINbox.Name = "PINbox";
            this.PINbox.Size = new System.Drawing.Size(234, 32);
            this.PINbox.TabIndex = 2;
            this.PINbox.Text = "PIN";
            this.PINbox.Click += new System.EventHandler(this.Passwordbox_Click);
            // 
            // AccountNumbox
            // 
            this.AccountNumbox.ForeColor = System.Drawing.Color.Silver;
            this.AccountNumbox.Location = new System.Drawing.Point(44, 144);
            this.AccountNumbox.Name = "AccountNumbox";
            this.AccountNumbox.Size = new System.Drawing.Size(234, 32);
            this.AccountNumbox.TabIndex = 1;
            this.AccountNumbox.Text = "Account Num";
            this.AccountNumbox.Click += new System.EventHandler(this.AccountNumbox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(120, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ATM.Properties.Resources.atm;
            this.pictureBox2.Location = new System.Drawing.Point(553, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Creatbtn
            // 
            this.Creatbtn.BackColor = System.Drawing.Color.Transparent;
            this.Creatbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Creatbtn.ButtonColor = System.Drawing.Color.SeaGreen;
            this.Creatbtn.FlatAppearance.BorderSize = 0;
            this.Creatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Creatbtn.Location = new System.Drawing.Point(44, 373);
            this.Creatbtn.Name = "Creatbtn";
            this.Creatbtn.OnHoverBorderColor = System.Drawing.Color.SeaGreen;
            this.Creatbtn.OnHoverButtonColor = System.Drawing.Color.White;
            this.Creatbtn.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.Creatbtn.Size = new System.Drawing.Size(234, 31);
            this.Creatbtn.TabIndex = 2;
            this.Creatbtn.Text = "Creat New Acc";
            this.Creatbtn.TextColor = System.Drawing.Color.White;
            this.Creatbtn.UseVisualStyleBackColor = false;
            this.Creatbtn.Click += new System.EventHandler(this.Creatbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(891, 583);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginbtn;
        private ePOSOne.btnProduct.Button_WOC Creatbtn;
        private System.Windows.Forms.TextBox PINbox;
        private System.Windows.Forms.TextBox AccountNumbox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

