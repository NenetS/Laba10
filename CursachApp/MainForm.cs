﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursachApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnFinds_Click(object sender, EventArgs e)
        {
            openChildForm(new Finds());
        }

        private void btnExhibit_Click(object sender, EventArgs e)
        {
            openChildForm(new Exhibit());
        }

        private void btnExcavations_Click(object sender, EventArgs e)
        {
            openChildForm(new Excavations());
        }
    }
}
