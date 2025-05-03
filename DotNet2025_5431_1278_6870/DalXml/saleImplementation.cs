using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    internal class saleImplementation : ISale
    {
        static string file_path = "../xml/sale.xml";
        public int Create(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start create sale");
            XElement saleXml = XElement.Load(file_path);
            Sale s = item with { SaleCode = Config.NextSaleCode };
            XElement e = new XElement("Sale",
                new XElement("SaleCode", s.SaleCode),
                new XElement("ProductId", s.ProductId),
                new XElement("QuantityForSale", s.QuantityForSale),
                new XElement("SalePrice", s.SalePrice),
                //new XElement("StartSale", s.StartSale),
                //new XElement("EndSale", s.EndSale)
                );
            saleXml.Add(e);
            if (s.IsClub!=null) {
                saleXml.Add(new XElement("IsClub",s.IsClub));
            }
            if (s.StartSale != null)
            {
                saleXml.Add(new XElement("StartSale", s.StartSale));
            }
            if (s.EndSale != null) {
                saleXml.Add(new XElement($"EndSale", s.EndSale));
            }
            saleXml.Save(file_path);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end create sale");
            return s.SaleCode;
        }
        //    int SaleCode,                    
        //int ProductId,
        //int QuantityForSale,
        //double SalePrice,
        //bool? IsClub,
        //DateTime? StartSale = null,
        //DateTime? EndSale = null
        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start delete sale");

            XElement xmlData = XElement.Load(file_path);
            List<Sale> users = new List<Sale>();

            foreach (var prod in xmlData.Elements("Sale"))
            {
                users.Add(new Sale
                {
                    SaleCode = prod.Element()
                });
            }

            return users;

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end delete sale");


        }

        public Sale? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read sale");

            try
            {
                return DataSource.Sales.Single(s => s?.SaleCode == code);
            }
            catch
            {
                throw new DalIdDoesNotExist("ERROR: id does not exist :products");
            }
        }
        public Sale? Read(Func<Sale, bool> filter)
        {LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read with filter sale");

            try
            {
                return DataSource.Sales.First(filter);
            }
            catch
            {
                throw new DalNotFound("ERROR: there is no element that meets the condition :sale");
            }
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read all with filter sale");

            if (filter == null)
                return new List<Sale>(DataSource.Sales);
            else
                return DataSource.Sales.Where(filter).ToList();

        }

        public void Update(Sale item)
        {

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start update sale");

            Delete(item.SaleCode);
            DataSource.Sales.Add(item);

            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " end update sale");

        }
    }
}
