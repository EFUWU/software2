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
    }
}
