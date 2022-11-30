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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActivityBox.Text == null || DateBox.Text == null || PlaceBox.Text == null)
            {
                MessageBox.Show("Tolong Isi Nama, Email, dan Password Terlebih Dahulu");
                return;
            }
            else
            {
                Task task = new Task();
                task.Activity = ActivityBox.Text;
                task.Date = DateBox.Text;
                task.Place = PlaceBox.Text;
                MessageBox.Show("Data Berhasil Disimpan");
                MainPage newForm = new MainPage();
                newForm.Show();
                this.Hide();
            }
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
