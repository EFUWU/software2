using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Firstnamebox_DoubleClick(object sender, EventArgs e)
        {
            Firstnamebox.ForeColor = Color.Black;
            Firstnamebox.Clear();
        }

        private void Lastnamebox_DoubleClick(object sender, EventArgs e)
        {
            Lastnamebox.ForeColor = Color.Black;
            Lastnamebox.Clear();
        }

        private void Mobilenumbox_DoubleClick(object sender, EventArgs e)
        {
            Mobilenumbox.ForeColor = Color.Black;
            Mobilenumbox.Clear();
        }

        private void Addressbox_DoubleClick(object sender, EventArgs e)
        {
            Addressbox.ForeColor = Color.Black;
            Addressbox.Clear();
        }

        private void Accountnumbox_DoubleClick(object sender, EventArgs e)
        {
            Accountnumbox.ForeColor = Color.Black;
            Accountnumbox.Clear();

        }

        private void Balancebox_DoubleClick(object sender, EventArgs e)
        {
            Balancebox.ForeColor = Color.Black;
            Balancebox.Clear();
        }

        private void PINbox_DoubleClick(object sender, EventArgs e)
        {
            PINbox.ForeColor = Color.Black;
            PINbox.Clear();
            PINbox.PasswordChar = '*';
        }

        private void ConfirmBox_DoubleClick(object sender, EventArgs e)
        {
            ConfirmBox.ForeColor = Color.Black;
            ConfirmBox.Clear();
            ConfirmBox.PasswordChar = '*';
        }

        private void Emailbox_DoubleClick(object sender, EventArgs e)
        {
            Emailbox.ForeColor = Color.Black;
            Emailbox.Clear();
        }

        private void showcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheckBox.Checked)
            {
                PINbox.PasswordChar = '\0';
                ConfirmBox.PasswordChar = '\0';

            }
            else
            {
                PINbox.PasswordChar = '*';
                ConfirmBox.PasswordChar = '*';
            }
        }
        private void form_size()
        {
            Size = new Size(1200, 800);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Create_Resize(object sender, EventArgs e)
        {
            form_size();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms[0].Show();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            int acc=int.Parse(Accountnumbox.Text);
            string f = Firstnamebox.Text;
            string l = Lastnamebox.Text;
            int phonenum = int.Parse(Mobilenumbox.Text);
            string address = Addressbox.Text;
            string g = GendercomboBox.Text;
            string d = dobdateTimePicker.Text;
            int PIN=int.Parse(PINbox.Text);
            string em = Emailbox.Text;

            ATMSYSTEM a = new ATMSYSTEM();
            a.insertdata(acc, f, l, phonenum, address, g, d, PIN, em);
        }

        private void Create_Load(object sender, EventArgs e)
        {
            this.atmdataTableAdapter.Fill(this.ATMDATADataSet.Accounts);
        }
    }
}
