using AT.Models.Enums;

namespace AT.Models.Software
{
    public class OS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PackageManager? PackageManager { get; set; }
        public Shell Shell { get; set; }

    }
}