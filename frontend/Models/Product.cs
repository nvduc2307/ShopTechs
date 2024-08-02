namespace Model
{
    public abstract class Product {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
    }

    public class Phone : Product {
        public PhoneType PhoneType{ get; set; }
        public Phone()
        {
            ProductType = ProductType.Phone;
            Name = PhoneType.ToString();
        }
    }

    public class Watch : Product {
        public WatchType WatchType { get; set;}
        public Watch()
        {
            ProductType = ProductType.Watch;
            Name = WatchType.ToString();
        }
    }
    public class AirPhone : Product {
        public AirPhoneType AirPhoneType{get; set;}
        public AirPhone()
        {
            ProductType = ProductType.AirPhone;
            Name = AirPhoneType.ToString();
        }
    }



    public enum ProductType {
        Phone = 1,
        Watch = 2,
        AirPhone = 3,
    }

    public enum PhoneType {
        Iphone7 = 1,
        Iphone8 = 2,
        Iphone9 = 3,
        Iphone10 = 4,
        Iphone11 = 5,
        SamSung1 = 6,
        SamSung2 = 7,
        SamSung3 = 8,
        SamSung4 = 9,
    }
    public enum WatchType {
        Watch1 = 1,
        Watch2 = 2,
        Watch3 = 3,
    }
    public enum AirPhoneType {
        AirPhone1 = 1,
        AirPhone2 = 4,
        AirPhone3 = 3,
    }
}