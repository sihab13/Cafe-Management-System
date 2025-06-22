using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace WindowsFormsApp1.AllUserControls
{
    public partial class UC_add : UserControl
    {
        public UC_add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            string ConnectString = "datasource = localhost; username=root; password=; database = coffe_management";
            MySqlConnection db = new MySqlConnection(ConnectString);
            db.Open();
               string q = "INSERT INTO item_list(Item_name, Category, Price) VALUES ('" + guna2ComboBox1.Text.ToString() + "','" + guna2TextBox1.Text.ToString() + "', '" + guna2TextBox2.Text.ToString() + "');";
            MySqlCommand cmd = new MySqlCommand(q, db);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Item Successfully");
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();

            
        }
    }
}
