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
    public partial class Create_Form : Form
    {
        public Create_Form()
        {
            InitializeComponent();
        }

        private void bgbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.namebox.Text != "" && this.namebox.Text != "" && this.emailbox.Text != "" && this.bgbox.Text != "" && this.mobilebox.Text != "" && this.catbox.Text != "")
            {
                try
                {

                    string MyConnection2 = "datasource = localhost; username = root; password=; database = phonebook";
                    string Query = "insert into datas(name,email,bloodgroup,mobile,category) values('" + this.namebox.Text + "','" + this.emailbox.Text + "','" + this.bgbox.Text + "','" + this.mobilebox.Text + "','" + this.catbox.Text + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Account Saved!");
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.namebox.Text == "")
            {
                MessageBox.Show("Insert Name in the text box!");
            }
            else if (this.emailbox.Text == "")
            {
                MessageBox.Show("Insert Email in the text box!");
            }
            else if (this.mobilebox.Text == "")
            {
                MessageBox.Show("Insert mobile number in the text box!");
            }
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

        private void bg1click(object sender, EventArgs e)
        {
            bgbox.Text = null;
            bgbox.ForeColor = Color.Black;
        }

        private void mob1click(object sender, EventArgs e)
        {
            mobilebox.Text = null;
            mobilebox.ForeColor = Color.Black;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            emailbox.Clear();
            bgbox.Clear();
            mobilebox.Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            search f = new search();
            f.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            show f = new show();
            f.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete f = new delete();
            f.ShowDialog();
        }
    }             
}
