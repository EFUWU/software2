using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ATM
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        public int AccNum;

        private void home_Load(object sender, EventArgs e)
        {
            ATMSYSTEM atm = new ATMSYSTEM();
            resulttime_label.Text = atm.time();
            /////////////////////////////////////
            string f, l;
            f=atmdataTableAdapter1.showFname(Login.AccNum).ToString();
            l = atmdataTableAdapter1.showLname(Login.AccNum).ToString();
            NameShowlabel.Text = f + " " + l;
                
            AccountnumShowlabel.Text = Login.AccNum.ToString();




        }

        private void Depositebtn_Click(object sender, EventArgs e)
        {
            Hide();
            Deposit d = new Deposit();
            d.Show();
        }

        private void Withdrawbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Withdraw frm = new Withdraw();
            frm.Show();
        }
        private void form_size()
        {
            Size = new Size(1200, 800);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            this.Location = new Point(x, y);
        }

        private void home_Resize(object sender, EventArgs e)
        {
            form_size();
        }

        private void Balancebtn_Click(object sender, EventArgs e)
        {
            Hide();
            Balance b = new Balance();
            b.Show();
        }

        private void Transferbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Transfer t = new Transfer();
            t.Show();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Close();
            Login l = new Login();
            l.Show();
        }

        private void FastCashbtn_Click(object sender, EventArgs e)
        {
            Hide();
            FastCash t = new FastCash();
            t.Show();
        }

        private void ministatementbutton_Click(object sender, EventArgs e)
        {
            Hide();
            MiniStatement mini = new MiniStatement();
            mini.Show();
        }
    }
    
}
