using System.ComponentModel.DataAnnotations.Schema;

namespace TuiTrackerCMS.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [NotMapped]
        public Address BillingAddress { get; set; } = new Address();
        [NotMapped]
        public Address DeliveryAddress { get; set; } = new Address();
        public string Notes { get; set; } = string.Empty;
    }
}
