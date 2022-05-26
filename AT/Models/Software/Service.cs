namespace AT.Models.Software
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Command>? Commands { get; set; }
    }
}
