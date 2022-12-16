using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOFinalProject
{
    public class Task
    {
        private string activity;
        private DateTime date;
        private DateTime time;
        private string place;

        public string Activity { get => activity; set => activity = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Place { get => place; set => place = value; }
        public DateTime Time { get => time; set => time = value; }

        public Task()
        {

        }
    }
}
