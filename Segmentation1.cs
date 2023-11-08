﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Denas
{
    public partial class frmSegmentation1 : Form
    {
        public frmSegmentation1()
        {
            InitializeComponent();
        }

        private void ovalShape2_Click(object sender, EventArgs e)
        {
            frmRun r = new frmRun();
            r.Show();
            this.Hide();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            frmFracture1 r = new frmFracture1();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matlabdlNative.matlabdll ma = new matlabdlNative.matlabdll();
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ma.showi(openFileDialog1.FileName);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matlabdlNative.matlabdll ma = new matlabdlNative.matlabdll();
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ma.skmeans(openFileDialog1.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matlabdlNative.matlabdll ma = new matlabdlNative.matlabdll();
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ma.smorphology(openFileDialog1.FileName);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matlabdlNative.matlabdll ma = new matlabdlNative.matlabdll();
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ma.scanny(openFileDialog1.FileName);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            matlabdlNative.matlabdll ma = new matlabdlNative.matlabdll();
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ma.sthreshold(openFileDialog1.FileName);

            }
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            frmRun r = new frmRun();
            r.Show();
            this.Hide();
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            frmAbout r = new frmAbout();
            r.Show();
            this.Hide();
        }

        private void rectangleShape5_Click(object sender, EventArgs e)
        {
            frmHelp r = new frmHelp();
            r.Show();
            this.Hide();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {
            frmSupport r = new frmSupport();
            r.Show();
            this.Hide();
        }

        private void rectangleShape6_Click(object sender, EventArgs e)
        {
            frmContact r = new frmContact();
            r.Show();
            this.Hide();
        }
    }
}
