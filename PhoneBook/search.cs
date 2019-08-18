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
namespace PhoneBook
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grid.Visible = true;
            try
            {
                string MyConnection2 = "datasource=localhost;username=root;password=;database=phonebook";
                string Query = "select * from datas where name like'%" + this.namebox.Text + "%' or email like'" + this.emailbox.Text + "' or mobile = '" + this.mobilebox.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                grid.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void name1click(object sender, EventArgs e)
        {
            namebox.Text = null;
            namebox.ForeColor = Color.Black;
        }

        private void clickonbox(object sender, EventArgs e)
        {
        }

        private void email1click(object sender, EventArgs e)
        {
            emailbox.Text = null;
            emailbox.ForeColor = Color.Black;
        }

        private void mob1click(object sender, EventArgs e)
        {
            mobilebox.Text = null;
            mobilebox.ForeColor = Color.Black;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Form f = new Create_Form();
            f.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            this.Hide();
            delete f = new delete();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            show f = new show();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mobilebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
