using System.Data.Entity.ModelConfiguration;

namespace BusinessLibrary.Accounting
{
    public class InvoiceLineMap : EntityTypeConfiguration<InvoiceLine>
    {
        public InvoiceLineMap()
        {
            ToTable("InvoiceLine", "acc");
        }
    }
}