using MyToDoPackage;
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
    public partial class TaskItem : UserControl
    {
        static TaskAPI taskAPI = new TaskAPI();
        MainPage mainPage;
        Task task;
        TimeZoneInfo toDoTimeZone = TimeZoneInfo.CreateCustomTimeZone("Custom Time Zone", new TimeSpan(+7, 0, 0), "Custom Time Zone", "Custom Time Zone");
        public TaskItem()
        {
            InitializeComponent();
        }
        public TaskItem(Task task, MainPage mainPage): this()
        {
            this.mainPage = mainPage;
            this.task = task;
            activityText.Text = task.Activity;
            placeText.Text = task.Place;
            dateText.Text = task.Date.ToShortDateString();
            timeText.Text = task.Date.ToShortTimeString();
            warningLabel.Text = ToDoBase.GetWarningLevel(task.Date, toDoTimeZone);
            if (warningLabel.Text == "Late")
            {
                warningLabel.BackColor = Color.Red;
            }
            else if(warningLabel.Text == "Urgent")
            {
                warningLabel.BackColor = Color.Orange;
            }
            else
            {
                warningLabel.BackColor= Color.Green;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                taskAPI.Delete(task.Id);
                MessageBox.Show(task.Id.ToString() + "is deleted");
                mainPage.loadData();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditPage editPage = new EditPage(task);
            editPage.Show();
            mainPage.Hide();
        }

        private void timeText_Click(object sender, EventArgs e)
        {

        }

        private void warningLabel_Click(object sender, EventArgs e)
        {

        }

        private void TaskItem_Load(object sender, EventArgs e)
        {

        }
    }
}
