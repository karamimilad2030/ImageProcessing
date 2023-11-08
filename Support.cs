using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Denas
{
    public partial class frmSupport : Form
    {
        public frmSupport()
        {
            InitializeComponent();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            frmMain r = new frmMain();
            r.Show();
            this.Hide();
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            frmContact r = new frmContact();
            r.Show();
            this.Hide();
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            frmSupport r = new frmSupport();
            r.Show();
            this.Hide();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            frmRun r = new frmRun();
            r.Show();
            this.Hide();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            frmAbout r = new frmAbout();
            r.Show();
            this.Hide();
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            frmHelp r = new frmHelp();
            r.Show();
            this.Hide();
        }
    }
}
