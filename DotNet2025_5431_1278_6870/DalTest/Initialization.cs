
using DO;
using DalApi;
    namespace DalTest
{
    public static class Initialization
    {
       private static IDal s_dal;
       
        private static List<int> productCode = new List<int>();
        public static void createProduct()
        {
            productCode.Add(s_dal.product.Create(new Product(0,"ביסלי",5.9,500, DO.Categories.SNACKS)));
            productCode.Add(s_dal.product.Create(new Product(0,"ציפס",6.9,600, DO.Categories.SNACKS)));
            productCode.Add(s_dal.product.Create(new Product(0,"שוקולד במילוי ליקר",5.9,10, DO.Categories.CHOCOLATES)));
            productCode.Add(s_dal.product.Create(new Product(0,"פיסטוק",2.9,20, DO.Categories.CRACKS)));
            productCode.Add(s_dal.product.Create(new Product(0,"ליקר שוקולד",42,20, DO.Categories.LIQUORS)));
            productCode.Add(s_dal.product.Create(new Product(0,"ג'לי נחשים",4.9,15, DO.Categories.JELLYS)));
        }

        private static List<int> customrCode = new List<int>();
        public static void createCustomer()
        {
            customrCode.Add(s_dal.customer.Create(new Customer(1234,"gili","netivot hamishpat 88","0556726659")));
            customrCode.Add(s_dal.customer.Create(new Customer(2344,"chani","netivot hamishpat 101","0333726659")));
            customrCode.Add(s_dal.customer.Create(new Customer(2345,"shoshana","netivot hamishpat 111","0556444459")));
            customrCode.Add(s_dal.customer.Create(new Customer(2346,"esti","netivot hamishpat 2","052222659")));
        }

        public static List<int> saleCode = new List<int>();
        public static void createSale()
        {
            saleCode.Add(s_dal.sale.Create(new Sale(0,101,3,12,false,DateTime.Now,DateTime.Now.AddDays(31))));
            saleCode.Add(s_dal.sale.Create(new Sale(0,100,3,12,false, DateTime.Now.AddDays(3), DateTime.Now.AddDays(10))));
            saleCode.Add(s_dal.sale.Create(new Sale(0,104,2,70,true)));
            saleCode.Add(s_dal.sale.Create(new Sale(0,105,0,3.9,false)));
        }
        public static void initelaize()
        {
            s_dal = DalApi.Factory.Get;

            createCustomer();
            createProduct();
            createSale();
        }
    }
}
