using System.Data.Entity;

namespace BusinessLibrary.Accounting
{
    public class AccountingContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<ProductReference> Products { get; set; }

        public AccountingContext() : base("name=MyDb")
        {
            Database.SetInitializer<AccountingContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoiceLineMap());
            modelBuilder.Configurations.Add(new ProductReferenceMap());
        }
    }
}