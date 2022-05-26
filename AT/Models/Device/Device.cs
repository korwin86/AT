using AT.Models.Software;

namespace AT.Models.Hardware
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string? Manufacturer { get; set; }
        public List<Service>? Services { get; set; }
        public List<Script>? Scripts { get; set; }
        public List<Utility>? Utilitys { get; set; }

    }
}
