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
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void backButton(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
