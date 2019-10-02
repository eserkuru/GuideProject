using System.ComponentModel.DataAnnotations;
using GuideProject.Northwind.Entities.Abstract;

namespace GuideProject.Northwind.Entities
{
    public class Product:BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public short UnitsInStock { get; set; }

    }
}
