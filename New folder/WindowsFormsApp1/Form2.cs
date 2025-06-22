using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Deshboard : Form
    {
        public Deshboard()
        {
            InitializeComponent();
        }
        public Deshboard(String user)
        {
            InitializeComponent();
            if (user=="Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
                btnLogOut.Hide();

            }
            if (user== "login")
            {
                linkLabel3.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uC_add1.Visible = false;
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_add1.Visible = true;
            uC_add1.BringToFront();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void uC_add1_Load(object sender, EventArgs e)
        {

        }
    }
}
