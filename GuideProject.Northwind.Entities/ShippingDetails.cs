using System.ComponentModel.DataAnnotations;
using GuideProject.Northwind.Entities.Abstract;

namespace GuideProject.Northwind.Entities
{
    public class ShippingDetails : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(15,75)]
        public int Age { get; set; }
    }
}
