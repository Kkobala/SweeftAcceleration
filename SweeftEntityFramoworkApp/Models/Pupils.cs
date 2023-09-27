namespace SweeftEntityFramoworkApp.Models
{
    public class Pupils
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Class { get; set; }

        public List<Teachers> Teachers { get; set; }

        public Pupils()
        {
            Teachers = new List<Teachers>();
        }
    }
}
