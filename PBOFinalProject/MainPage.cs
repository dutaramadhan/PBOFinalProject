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
    public partial class MainPage : Form
    {
        private LoginPage loginPage;

        static TaskAPI taskAPI = new TaskAPI();

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(LoginPage loginPage)
        {
            this.loginPage = loginPage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            List<Task> tasks = taskAPI.GetTasks();
            foreach (Task task in tasks)
            {
                TaskItem taskItem = new TaskItem(task, this);
                ActivityListBox.Controls.Add(taskItem);
            }
            ActivityListBox.Controls.Add(new TaskItem());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add newForm = new Add();
            newForm.Show();
            this.Hide();
            
        }

        private void ActivityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

    }
}
