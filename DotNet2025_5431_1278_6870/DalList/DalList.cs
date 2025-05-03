using DalApi;


namespace Dal
{
    internal sealed class DalList: IDal
    {
        
        public IProduct product => new ProductImplementation();
        public ICustomer customer => new CustomerImplementation();
        public ISale sale => new SaleImplementation();
        public static readonly DalList instance  = new DalList();
        public static DalList getInstance => instance ;

    }
}
