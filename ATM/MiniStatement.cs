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
    public partial class MiniStatement : Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }

        private void ministatementTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ministatementTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aTMDATADataSet);

        }

        private void MiniStatement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aTMDATADataSet.ministatementTable' table. You can move, or remove it, as needed.
            this.ministatementTableTableAdapter.Fill(this.aTMDATADataSet.ministatementTable,Login.AccNum);
            ATMSYSTEM atm = new ATMSYSTEM();
            resulttime_label.Text = atm.time();
            //////////////////////////////////////
            string f, l;
            f = atmdataTableAdapter1.showFname(Login.AccNum).ToString();
            l = atmdataTableAdapter1.showLname(Login.AccNum).ToString();
            NameShowlabel.Text = f + " " + l;
            //AccountnumShowlabel.Text = Login.AccNum.ToString();

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Close();
            home h = new home();
            h.Show();
        }

        private void ministatementTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
