using DO;
namespace Dal

{
    static internal class DataSource
    {
        static internal List<Product?> Products = new List<Product?>();
        static internal List<Customer?> Customers = new List<Customer?>();
        static internal List<Sale?> Sales = new List<Sale?>();
       

        static internal class Config
        {
            internal const int START_PRODUCT_ID = 100;
            private static int productCode = START_CODE_SALE;

            internal const int START_CODE_SALE = 100;
            private static int saleCode = START_CODE_SALE;


            public static int SaleCode { get { return saleCode++; } }
            public static int ProductCode { get { return productCode++; } }


        }
    }

 
}
