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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            

            Size = new Size(907, 599);
                int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
                int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
                this.Location = new Point(x, y);
            
           
        }

        private void AccountNumbox_Click(object sender, EventArgs e)
        {
            AccountNumbox.ForeColor = Color.Black;
            AccountNumbox.Clear();
            if (PINbox.Text == "")
            {
                PINbox.ForeColor = Color.Silver;
                PINbox.Text = "Password";
            }
        }

        private void Passwordbox_Click(object sender, EventArgs e)
        {
            PINbox.ForeColor = Color.Black;
            PINbox.Clear();

            PINbox.PasswordChar = '*';
            if (AccountNumbox.Text == "")
            {
                AccountNumbox.ForeColor = Color.Silver;
                AccountNumbox.Text = "Account Num";
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                PINbox.PasswordChar = '\0';

            }
            else
            {
                PINbox.PasswordChar = '*';
            }
        }

        private void Creatbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Create frm = new Create();
            frm.ShowDialog();
        }
        public static int AccNum;
        private void loginbtn_Click(object sender, EventArgs e)
        {
            try 
            { 
            AccNum=int.Parse(AccountNumbox.Text);
            if (atmdataTableAdapter.loginQuery(AccNum) == int.Parse(PINbox.Text))
                {
                home h = new home();
                h.Show();
                Hide();
                }
            else
                {
                MessageBox.Show("Invalid Account Num or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
