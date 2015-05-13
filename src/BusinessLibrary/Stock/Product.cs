namespace BusinessLibrary.Stock
{
    public class Product
    {
        public int Id { get; set; }

        public string Sku { get; set; }

        public string Description { get; set; }
        public string DataSheet { get; set; }
        public bool IsActive { get; set; }
    }
}
