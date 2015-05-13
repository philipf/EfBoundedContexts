using System.Data.Entity;

namespace BusinessLibrary.Accounting
{
    public class AccountingContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }

        public AccountingContext() : base("name=MyDb") {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoiceLineMap());
        }
    }
}