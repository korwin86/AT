namespace AT.Models
{
    public class OS : Software
    {
        public PackageManager PackageManager { get; set; }
        public Shell Shell { get; set; }
    }
}
