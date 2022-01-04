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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
            home hm = new home();
            hm.Show();

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

        private void Deposit_Resize(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter the number you want to Deposit.");
                }
                else if (int.Parse(AmountBox.Text) <= 0)
                {
                    MessageBox.Show("Enter the correct amount to withdraw.");
                }
                else
                {
                    string type = "Deposit";
                    int bal = int.Parse(AmountBox.Text);
                    int new_balance = bal + old_balance;
                    atmdataTableAdapter1.UpdateBalance(new_balance, Login.AccNum);
                    MessageBox.Show("Deposited successfully.");
                    ministatementTableTableAdapter1.InsertMini(Login.AccNum,type,bal,new_balance,DateTime.Today.Date.ToString());
                  //  ministatementTableTableAdapter1.restoredata(Login.AccNum);
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                
            }

        private void Deposit_Load(object sender, EventArgs e)
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

