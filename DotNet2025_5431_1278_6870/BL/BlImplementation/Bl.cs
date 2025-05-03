

using BlApi;
using BLApi;

namespace BlImplementation;

internal class Bl : IBl
{
    public ICustomer Customer => new CustomerImplementation();

    public IProduct Product =>  new ProductImplementation();

    public IOrder Order =>  new OrderImplamention();

    public ISale sale =>  new SalesImplemention();

}
