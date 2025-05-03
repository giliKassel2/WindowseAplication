
using System.Reflection;
using DalApi;
using DO;
using Tools;



namespace Dal
{
    internal class CustomerImplementation:ICustomer
    {
        public int Create(Customer item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod().Name, "start create customer");
            if (DataSource.Customers.Any(c=>item.Id == c?.Id))
            {
                throw new DalIdAlreadyExists("ERROR: id already exists :customer");
            }
            DataSource.Customers.Add(item);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod()!.Name, "end create customer");
            return item.Id;
        }

        public Customer? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read customer");
            try
            {
                return DataSource.Customers.Single(s => s?.Id == id);
            }
            catch 
            {
                throw new DalIdDoesNotExist("ERROR: id does not exist :customer");
            }

        }
        public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter - customer");
            
            if (filter == null)
                return new List<Customer>(DataSource.Customers);
            else return DataSource.Customers.Where(filter).ToList();

        }
    
        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete customer");

            Customer? customerToDelete = Read(id);
            DataSource.Customers.Remove(customerToDelete);

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete customer");
        }

        public void Update(Customer item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update customer");

            Delete(item.Id);
            DataSource.Customers.Add(item);

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end update customer");
        }

        Customer? ICrud<Customer>.Read(Func<Customer, bool> filter)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read with filter - customer");

            try
            {
                return DataSource.Customers.First(filter);
            }
            catch
            {
                throw new DalNotFound("ERROR: there is no customer that meets the condition :customer");
            }

        }
    }
}
