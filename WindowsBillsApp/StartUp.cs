using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBillsApp
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cusForm = new frmCustomer();
            cusForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form subForm = new frmSubscription();
            subForm.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form billForm = new frmBill();
            billForm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }
    }
}
