namespace Deneme
{
    class Product
    {
        public int ProductCode { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Seller { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public float ProductPoint { get; set; }
    }

    class Clothes : Product
    {
        public int ClothesId { get; set; }
        public int ClothesSize { get; set; }
    }

    class Shoes : Product
    {
        public int ShoesId { get; set; }
        public int ShoesSize { get; set; }
    }
}
