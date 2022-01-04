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

        private void home_Load(object sender, EventArgs e)
        {
            string x;
            string y;
            y = DateTime.Now.ToLongTimeString();
            x = DateTime.Now.ToLongDateString();
            resulttime_label.Text = x + "\n         " + y;
            /////////////////////////////////////////////
            AccountnumShowlabel.Text = Login.AccNum;
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=DESKTOP-L21BLDF\SQLEXPRESS;Initial Catalog=ATMDATA;Integrated Security=True";
            sc.Open();
            SqlDataAdapter fn = new SqlDataAdapter(" select fname from atmdata where accountnum='" + AccountnumShowlabel.Text + "'", sc);
            SqlDataAdapter ln = new SqlDataAdapter(" select lname from atmdata where accountnum='" + AccountnumShowlabel.Text + "'", sc);
            DataTable dt = new DataTable();
            DataTable ddt = new DataTable();
            fn.Fill(dt);
            ln.Fill(ddt);
            NameShowlabel.Text = dt.Rows[0][0].ToString() + " " + ddt.Rows[0][0].ToString();
            sc.Close();
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
    }
    
}
