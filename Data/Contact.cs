using System.ComponentModel.DataAnnotations;

namespace Blazor.Playground.Data
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [StringLength(5,
            MinimumLength = 5,
            ErrorMessage = "Postal Code must be 5 characters")]
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}