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
    internal  class productImplementation : IProduct
    {
        static string file_path = "../xml/products.xml";
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
        public int Create(Product item)
        {
           
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Create Product");
            item = item with {ProductCode = Config.NextProductCode };
            List<Product> products = new List<Product>();
                products = Config.LoadFromXml<Product>(file_path);
            bool Product = products.Any(c => c?.ProductCode == item.ProductCode);

            if (Product)
            {
                throw new DalIdAlreadyExists("Create - ERROR: Product Id already exists");
            }

            products.Add(item);
            Config.SaveToXml(file_path, products);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Create Product");
            return item.ProductCode;

        }

        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start delete Product");

            List<Product> products = new List<Product>();

            products = Config.LoadFromXml<Product>(file_path);
            Product ProductToDelete = products.FirstOrDefault(c => c?.ProductCode == id);
            if (ProductToDelete != null)
            {
                products.Remove(ProductToDelete);
                Config.SaveToXml(file_path, products);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete Product");
            }
            else
            {
                throw new DO.DalIdAlreadyExists("Delete - ERROR: Product Id not exists");
            }
        }

        public Product? Read(int id)
        {

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start read Product");
            List<Product> products = new List<Product>();
                products = Config.LoadFromXml<Product>(file_path);
                Product findProduct = products.FirstOrDefault(c => c?.ProductCode == id);
                if (findProduct != null)
                {
                    return findProduct;
                }
                throw new DO.DalIdAlreadyExists("Read - ERROR: Product Id not exists");
            
        }

        public Product? Read(Func<Product, bool> filter)
        {
            List<Product> products = new List<Product>();
            
           
                products = Config.LoadFromXml<Product>(file_path);
                Product findProduct = products.FirstOrDefault(filter);
                return findProduct;
            
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " readAll with filter Product");
            List<Product> products = new List<Product>();
            
                products = Config.LoadFromXml<Product>(file_path);
                if (filter == null)
                {
                    return products;
                }
                return products.Where(filter).ToList();
            
        }

        public void Update(Product item)
        {
            try
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "start update Product");

                List<Product> products = new List<Product>();
                if (File.Exists(file_path))
                {
                    products = Config.LoadFromXml<Product>(file_path);
                    Product ProductToDelete = products.FirstOrDefault(c => c.ProductCode == item.ProductCode);
                    if (ProductToDelete != null)
                    {
                        products.Remove(ProductToDelete);
                        products.Add(item);
                        Config.SaveToXml(file_path, products);
                        LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete Product");
                    }
                    else
                    {
                        throw new DO.DalIdDoesNotExist("Delete - ERROR: Product Id not exists");
                    }
                }
                else
                {
                    throw new DalIdDoesNotExist("this file doesnt exist!");
                }
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update Product");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
