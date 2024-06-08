namespace TuiTrackerCMS.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public double CostPerUnit { get; set; } = 00.00;
        public Business Supplier { get; set; } = new Business();
        public string Notes { get; set; } = string.Empty;
    }
}
