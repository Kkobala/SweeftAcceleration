namespace SweeftEntityFramoworkApp.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Subject { get; set; }

        public List<Pupils> Pupils { get; set; }

        public Teachers()
        {
            Pupils = new List<Pupils>();
        }
    }
}
