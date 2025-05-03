

namespace DalApi
{
    public interface IDal
    {
        IProduct product { get; }
        ICustomer customer { get; }
        ISale sale { get; }

    }
}
