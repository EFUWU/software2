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
    public partial class Balance : Form
    {
        public Balance()
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
            Size = new Size(834, 500);
            int x = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            this.Location = new Point(x, y);
        }
        private void Balance_Resize(object sender, EventArgs e)
        {
            form_size();
        }
       
        private void Balance_Load(object sender, EventArgs e)
        {
            ATMSYSTEM atm = new ATMSYSTEM();
            resulttime_label.Text = atm.time();
            //////////////////////////////////////
            string f, l;
            f = atmdataTableAdapter1.showFname(Login.AccNum).ToString();
            l = atmdataTableAdapter1.showLname(Login.AccNum).ToString();
            NameShowlabel.Text = f + " " + l;
            AccountnumShowlabel.Text = Login.AccNum.ToString();
           balancelabel.Text= atmdataTableAdapter1.showBalance(Login.AccNum).ToString();
            
        }
    }
}
