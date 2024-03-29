namespace JuanApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public int IsDeleted { get; set; }
        public List<ProductImage> ProductImages { get; set; } = null!;
        //public string Category { get; set; }
        //public string CategoryName { get; set; }

    }
}
