using System.ComponentModel.DataAnnotations.Schema;

namespace JuanApp.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } = null!;
    }
}
