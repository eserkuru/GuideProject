using GuideProject.Northwind.Entities.Abstract;

namespace GuideProject.Northwind.Entities
{
    public class Category:BaseEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
