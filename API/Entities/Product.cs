
namespace API.Entities
{
    public class Product
    {
        public int id { get; set; }
        public required string name { get; set; }
        public long unitPrice { get; set; }
        public string imageUrl { get; set; }
        public bool soldOut { get; set; }
    }
}