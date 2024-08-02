using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductEntity {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
        [Required]
        public int ProductInfoType { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? Images { get; set; }
        [Required]
        public bool IsHot { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }

    public enum ProductType {
        Phone = 1,
        Watch = 2,
        AirPhone = 3,
    }
}