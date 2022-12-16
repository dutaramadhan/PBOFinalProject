namespace API.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public Task(int id, string name, DateTime date, string place)
        {
            Id = id;
            Name = name;
            Date = date;
            Place = place;
        } 
    }
}
