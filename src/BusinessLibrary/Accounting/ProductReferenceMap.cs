using System.Data.Entity.ModelConfiguration;

namespace BusinessLibrary.Accounting
{
    public class ProductReferenceMap : EntityTypeConfiguration<ProductReference>
    {
        public ProductReferenceMap()
        {
            ToTable("Product", "stock");
        }
    }
}