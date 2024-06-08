using System.ComponentModel.DataAnnotations.Schema;

namespace TuiTrackerCMS.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [NotMapped]
        public Address BillingAddress { get; set; } = new Address();
        [NotMapped]
        public Address DeliveryAddress { get; set; } = new Address();
        public Contact PrimaryContact { get; set; } = new Contact();
        public Contact AccountsContact { get; set; } = new Contact();
        public Contact[] AdditionalContacts { get; set; } = Array.Empty<Contact>();
        public string NZBN { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public bool IsSupplier { get; set; } = false;
    }
}
