using AT.Models.Software;

namespace AT.Models.Hardware
{
    public class Server : Hardware
    {
        public OS OperatingSystem { get; set; }
        public string? ManagementPort { get; set; }
        public Hypervisor? Hypervisor { get; set; }
        public bool? IsVirtual { get; set; }   

    }
}
