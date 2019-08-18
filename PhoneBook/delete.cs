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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void name1click(object sender, EventArgs e)
        {
            namebox.Text = null;
            namebox.ForeColor = Color.Black;
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource = localhost; username = root; password=; database = phonebook";
                string Query = "delete from datas where name='" + this.namebox.Text + "'or email='"+this.emailbox.Text+"'or mobile='"+this.mobilebox.Text+"';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
           search f = new search();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            show f = new show();
            f.ShowDialog();

        }
    }
}
