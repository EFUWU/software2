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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Hide();
            home frm = new home();
            frm.Show();
        }
        private void form_size()
        {
            Size = new Size(848, 537);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Cancelbtn_Resize(object sender, EventArgs e)
        {
            
        }

        private void Withdraw_Resize(object sender, EventArgs e)
        {
            form_size();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int old_balance = Convert.ToInt32(atmdataTableAdapter1.showBalance(Login.AccNum));
                if (AmountBox.Text == "")
                {
                    MessageBox.Show("Please enter the number you want to withdraw.");
                }
                 else if (int.Parse(AmountBox.Text) <= 0)
                {
                    MessageBox.Show("Enter the correct amount to withdraw.");
                }
                else if (Convert.ToInt32(AmountBox.Text) > old_balance)
                {
                    MessageBox.Show("You cannot withdraw, Please enter a valid number again.");
                }
                else
                {
                    string type = "Withdrawn";
                    int bal = int.Parse(AmountBox.Text);
                    int new_balance = old_balance-bal;
                    atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                    MessageBox.Show("Withdrawn successfully.");
                    ministatementTableTableAdapter1.InsertMini(Login.AccNum, type, bal, new_balance, DateTime.Today.Date.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Withdraw_Load(object sender, EventArgs e)
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
    }
}
