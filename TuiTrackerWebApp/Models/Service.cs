namespace TuiTrackerCMS.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceCode { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public string ServiceDescription { get; set; } = string.Empty;
        public double RatePerHour { get; set; } = 00.00;
        public double RatePerItem { get; set; } = 00.00;
        public Material[] MaterialsRequired { get; set; } = Array.Empty<Material>();
        public string Notes { get; set; } = string.Empty;
    }
}
