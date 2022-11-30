using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOFinalProject
{
    internal class Task
    {
        private string activity;
        private string date;
        private string place;

        public string Activity { get => activity; set => activity = value; }
        public string Date { get => date; set => date = value; }
        public string Place { get => place; set => place = value; }

        public Task()
        {

        }
    }
}
