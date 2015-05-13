using System.Data.Entity;

namespace BusinessLibrary.Stock
{
    public class StockContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public StockContext() : base("name=MyDb") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}