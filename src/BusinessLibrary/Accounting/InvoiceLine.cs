namespace BusinessLibrary.Accounting
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual ProductReference Product { get; set; }
    }
}