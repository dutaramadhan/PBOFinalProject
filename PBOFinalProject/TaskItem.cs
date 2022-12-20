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
        public TaskItem()
        {
            InitializeComponent();
        }
        public TaskItem(Task task): this()
        {
            activityText.Text = task.Activity;
            placeText.Text = task.Place;
            dateText.Text = task.Date.ToShortDateString();
            timeText.Text = task.Time.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
