namespace NoutShop.Models
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
