namespace AT.Models.Software
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Service Service { get; set; }
        public string Value { get; set; }
        public List<string>? Keys { get; set; }
    }
}