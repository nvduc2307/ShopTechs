namespace Model
{
    public abstract class Product {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductInfoType { get; set; }
        public double Price { get; set; }
        public string? Images { get; set; }
        public bool IsHot { get; set; }
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