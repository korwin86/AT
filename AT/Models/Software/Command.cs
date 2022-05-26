namespace AT.Models.Software
{
    public class Command : Software
    {
        public Service Service { get; set; }
        public string Value { get; set; }
        public List<string>? Keys { get; set; }
    }
}