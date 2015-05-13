using System;
using System.Linq;
using BusinessLibrary.Accounting;
using BusinessLibrary.Stock;

namespace TestBedCli
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateProducts();
            //CreateInvoice();
            LookupInvoice();

            Console.WriteLine("Done, press enter.");
            Console.ReadLine();
        }

        private static void LookupInvoice()
        {
            using (var ctx = new AccountingContext())
            {
                var invoice = ctx.Invoices.First();
                Console.WriteLine(invoice.Lines.First().Product.Sku);
            }
        }

        private static void CreateInvoice()
        {
            using (var ctx = new AccountingContext())
            {
                var invoice = new Invoice("TEST1");
                ctx.Invoices.Count();
                var productReference = ctx.Products.First(p => p.Sku == "P1");

                invoice.AddLines(10, productReference);


                ctx.Invoices.Add(invoice);
                ctx.SaveChanges();
            }
        }

        static void CreateProducts()
        {
            using (var ctx = new StockContext())
            {
                ctx.Products.Add(new Product {Sku = "P1", Description = "Product 1", IsActive = true});
                ctx.Products.Add(new Product {Sku = "P2", Description = "Product 2", IsActive = true});

                ctx.SaveChanges();
            }
        }
    }
}
