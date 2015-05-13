using System.Data.Entity.ModelConfiguration;

namespace BusinessLibrary.Stock
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product", "stock");
        }
    }
}