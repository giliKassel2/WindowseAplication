using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;
namespace Dal
{
    internal class customerImplementation : ICustomer
    {

        static string file_path = "../xml/customers.xml";
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        public int Create(Customer item)
        {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod().Name, "start create customer");
                List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
            if (customers.Any(c => c?.Id == item.Id))
            {
                throw new DalIdAlreadyExists("ERROR: The customer ID already exists : Customer");
            }
                customers.Add(item);
                Config.SaveToXml(file_path, customers);

                LogManager.writeToLog(MethodBase.GetCurrentMethod()!.DeclaringType!.FullName!, MethodBase.GetCurrentMethod().Name, "end create customer");
                return item.Id;
            
         
        }

        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete customer");

            List<Customer> customers = Config.LoadFromXml<Customer>(file_path);
            Customer? customerToDelete = Read(id);
            
            customers.Remove(customerToDelete);
            Config.SaveToXml(file_path, customers);


            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete customer");
           
        }

        public Customer? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read customer");
            try
            {
                List<Customer> customers = Config.LoadFromXml<Customer>(file_path); 
                return customers.Single(s => s?.Id == id);
            }
            catch
            {
                throw new DalIdDoesNotExist("ERROR: id does not exist :customer");
            }
        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " read with filter - customer");

            List<Customer> customers = new List<Customer>();
           customers = Config.LoadFromXml<Customer>(file_path);
            Customer findCustomer = customers.FirstOrDefault(filter);
            return findCustomer;
            
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter - customer");

            List<Customer> customers = new List<Customer>();
            customers = Config.LoadFromXml<Customer>(file_path);
            if (filter == null)
                return customers;
            else return customers.Where(filter).ToList();

        }

        public void Update(Customer item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update customer");

            Delete(item.Id);
            Create(item);

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end update customer");

        }
    }
}
