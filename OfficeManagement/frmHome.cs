using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeManagement
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void inquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInquiry fInq = new frmInquiry();
            fInq.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void repairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepair fr = new frmRepair();
            fr.Show();
        }
    }
}
