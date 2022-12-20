using PBOFinalProject.UsingAPI;
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
        static TaskAPI taskAPI = new TaskAPI();
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
            if (ActivityBox.Text == null || dateBox.Value == null || timeBox.Value==null ||PlaceBox.Text == null || ActivityBox.Text == "" || PlaceBox.Text == "")
            {
                MessageBox.Show("Tolong Isi Nama, Tanggal, dan Tempat Kegiatan Terlebih Dahulu");
                return;
            }
            else if (dateBox.Value.Date == DateTime.Now || timeBox.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Masukan tanggal dan jam yang valid");
            }
            else if (dateBox.Value.Date < DateTime.Now.Date){
                MessageBox.Show("Masukan tanggal yang valid");
            }
            else
            {
                Task task = new Task();
                task.Activity = ActivityBox.Text;
                task.Date = dateBox.Value.Date ;
                task.Time = timeBox.Value.TimeOfDay;
                task.Place = PlaceBox.Text;
                taskAPI.Create(task);

                MessageBox.Show("Data Berhasil Disimpan");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }


        private void dateBox_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void timeBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
