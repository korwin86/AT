using AT.Models.Software;

namespace AT.Models.Hardware
{
    public class Workstation : Device
    {
        public OS OperatingSystem { get; set; }
        public bool? IsVirtual { get; set; }

    }
}
