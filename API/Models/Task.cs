using System.Diagnostics;

namespace API.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Activity { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Place { get; set; } = string.Empty;

        public Task()
        {

        }
    }
}
