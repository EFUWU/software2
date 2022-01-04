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
    public partial class CurrencyExchange : Form
    {
        public CurrencyExchange()
        {
            InitializeComponent();
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
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

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
           // atmdataTableAdapter1.
        }
    }
}
