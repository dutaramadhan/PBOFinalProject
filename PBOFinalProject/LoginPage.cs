using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOFinalProject
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == null || EmailBox.Text == null || PasswordBox.Text==null || NameBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Tolong Isi Nama, Email, dan Password Terlebih Dahulu");
                return;
            }
            else
            {
                User users = new User();
                users.Name = NameBox.Text;
                users.Email = EmailBox.Text;
                users.Password= PasswordBox.Text;
                MessageBox.Show("Input data berhasil dilakukan");
                MainPage newForm = new MainPage();
                newForm.Show();
                this.Hide();
            }
        }
    }
}
