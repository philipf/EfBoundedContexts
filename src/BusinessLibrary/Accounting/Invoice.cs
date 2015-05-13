using System.Collections.Generic;

namespace BusinessLibrary.Accounting
{
    public class Invoice
    {
        public int Id { get; set; }

        public string DocumentNumber { get; set; }

        public virtual ICollection<InvoiceLine> Lines { get; set; }

        protected Invoice()
        {
            Lines = new List<InvoiceLine>();
        }

        public Invoice(string documentNumber) : this()
        {
            DocumentNumber = documentNumber;
        }

        public void AddLines(int quantity, ProductReference productReference)
        {
            var line = new InvoiceLine();
            line.Quantity = quantity;
            line.Product = productReference;

            Lines.Add(line);
        }
    }
}
