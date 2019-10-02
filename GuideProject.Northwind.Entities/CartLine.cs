using GuideProject.Northwind.Entities.Abstract;

namespace GuideProject.Northwind.Entities
{
    public class CartLine : BaseEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
