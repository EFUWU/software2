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
    }
}
