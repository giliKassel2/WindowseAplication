using System.Reflection;
using DalApi;
using DO;
using Tools;


namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        public int Create(Product item)
        {
            Product product = item with { ProductCode = DataSource.Config.ProductCode };
            DataSource.Products.Add(product);
            return product.ProductCode;
        }

        public Product? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start read Product");

            try
            {
                return DataSource.Products.Single(p => p?.ProductCode == id);
            }
            catch 
            {
                throw new DalIdDoesNotExist("ERROR: id does not exist :product");
            }
            
           
        }

        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete Product");

            DataSource.Products.Remove(Read(id));
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete Product");

        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter Product");

            if (filter == null)
            return new List<Product>(DataSource.Products);
            else return DataSource.Products.Where(filter).ToList();   
                
        }
        public void Update(Product item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update Product");

            Delete(item.ProductCode);
            DataSource.Products.Add(item);

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update Product");

        }

        public Product? Read(Func<Product, bool> filter)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read Product");
            try
            {
                return DataSource.Products.First(filter);
            }
            catch
            {
                throw new DalNotFound("ERROR: there is no product that meets the condition :products");
            }
        }
    }
    
}

