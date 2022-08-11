


namespace Catalog.Services.Queries.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ProductInStockDTO Stock { get; set; }

    }
}
