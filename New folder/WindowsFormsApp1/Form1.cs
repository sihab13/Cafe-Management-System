using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Deshboard ds = new Deshboard("Guest");
            ds.ShowDialog();
            
            
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ConnectString = "datasource = localhost; username=root; password=; database = coffe_management";
            MySqlConnection db = new MySqlConnection(ConnectString);
            db.Open();

            string q = "select * from admin where user_id='" + tb1.Text.ToString()+ "' and pass='" + tb2.Text.ToString() + "'";
            MySqlDataAdapter c1 = new MySqlDataAdapter(q, db);
            DataTable dtb1 = new DataTable();
            c1.Fill(dtb1);
            if(dtb1.Rows.Count ==1)
            {

                MessageBox.Show("log in successfully");
                this.Hide();
                Deshboard fm = new Deshboard("login");
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
