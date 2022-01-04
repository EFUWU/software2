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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Close();
            home h = new home();
            h.Show();
        }
        private void form_size()
        {
            Size = new Size(1200, 800);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            this.Location = new Point(x, y);
        }

        private void FastCash_Resize(object sender, EventArgs e)
        {
            form_size();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            ATMSYSTEM atm = new ATMSYSTEM();
            resulttime_label.Text = atm.time();
            //////////////////////////////////////
            string f, l;
            f = atmdataTableAdapter1.showFname(Login.AccNum).ToString();
            l = atmdataTableAdapter1.showLname(Login.AccNum).ToString();
            NameShowlabel.Text = f + " " + l;
            AccountnumShowlabel.Text = Login.AccNum.ToString();
        }

        private void b100button_Click(object sender, EventArgs e)
        {
            int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
            if (old_balance < 100)
            {
                MessageBox.Show("The amount in the account is not enough to withdraw");
            }
            else
            {
                string type = "Withdrawn(100)";
                int bal = 100;
                int new_balance = old_balance - 100;
                atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                MessageBox.Show("Withdrawn successfully.");
                ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());

            }
        }

        private void b500button_Click(object sender, EventArgs e)
        {
            int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
            if (old_balance < 500)
            {
                MessageBox.Show("The amount in the account is not enough to withdraw");
            }
            else
            {
                string type = "Withdrawn(500)";
                int bal = 500;
                int new_balance = old_balance - 500;
                atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                MessageBox.Show("Withdrawn successfully.");
                ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());

            }
        }

        private void b1000button_Click(object sender, EventArgs e)
        {
            int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
            if (old_balance < 1000)
            {
                MessageBox.Show("The amount in the account is not enough to withdraw");
            }
            else 
            {
                string type = "Withdrawn(1000)";
                int bal = 1000;
                int new_balance = old_balance - 1000;
                atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                MessageBox.Show("Withdrawn successfully.");
                ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());

            }
        }

        private void b2000button_Click(object sender, EventArgs e)
        {
            int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
            if (old_balance < 2000)
            {
                MessageBox.Show("The amount in the account is not enough to withdraw");
            }
            else
            {
                string type = "Withdrawn(2000)";
                int bal = 2000;
                int new_balance = old_balance - 2000;
                atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                MessageBox.Show("Withdrawn successfully.");
                ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());

            }
        }

        private void b2500button_Click(object sender, EventArgs e)
        {
            int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
            if (old_balance < 500)
            {
                MessageBox.Show("The amount in the account is not enough to withdraw");
            }
            else
            {
                string type = "Withdrawn(2500)";
                int bal = 2500;
                int new_balance = old_balance - 2500;
                atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                MessageBox.Show("Withdrawn successfully.");
                ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());

            }
        }

        private void anotheramountbutton_Click(object sender, EventArgs e)
        {
            Close();
            Withdraw w = new Withdraw();
            w.Show();
        }
    }
}
