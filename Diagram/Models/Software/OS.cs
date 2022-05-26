using AT.Models.Enums;

namespace AT.Models.Software
{
    public class OS : Software
    {

        public PackageManager? PackageManager { get; set; }
        public Shell Shell { get; set; }

    }
}