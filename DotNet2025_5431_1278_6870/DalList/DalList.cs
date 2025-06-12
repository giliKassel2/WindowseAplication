using DalApi;


namespace Dal
{
    internal sealed class DalList : IDal
    {

        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        private DalList() { }

        public static readonly DalList instance = new DalList();
        public static DalList Instance  { get { return instance; } }
};

    }

