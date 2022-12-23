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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace PBOFinalProject
{
    public partial class EditPage : Form
    {
        Task task;
        static TaskAPI taskAPI = new TaskAPI();
        public EditPage(Task task)
        {
            InitializeComponent();
            this.task = task;
            EditActivityBox.Text = task.Activity;
            EditDateBox.Value = task.Date.Date;
            EditTimeBox.Value = task.Date;
            EditPlaceBox.Text = task.Place;
                
           
        }

        private void backButton(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditActivityBox.Text == null || EditDateBox.Value == null || EditTimeBox.Value == null || EditPlaceBox.Text == null || EditActivityBox.Text == "" || EditPlaceBox.Text == "")
            {
                MessageBox.Show("Tolong Isi Nama, Tanggal, dan Tempat Kegiatan Terlebih Dahulu");
                return;
            }
            else if (EditDateBox.Value.Date == DateTime.Now.Date && EditTimeBox.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Masukan tanggal dan jam yang valid");
            }
            else if (EditDateBox.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Masukan tanggal yang valid");
            }
            else
            {
                task.Activity = EditActivityBox.Text;
                task.Date = EditDateBox.Value.Date;
                task.Date = task.Date.Add(EditTimeBox.Value.TimeOfDay);
                task.Place = EditPlaceBox.Text;
                taskAPI.Update(task);

                MessageBox.Show("Data Berhasil Disimpan");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        }

        private void EditPage_Load(object sender, EventArgs e)
        {

        }
    }
}

