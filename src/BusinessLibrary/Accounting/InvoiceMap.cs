using System.Data.Entity.ModelConfiguration;

namespace BusinessLibrary.Accounting
{
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            ToTable("Invoice", "acc");
        }
    }
}