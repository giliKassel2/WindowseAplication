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
    //[Serilalizable]
    internal class saleImplementation : ISale
    {
        static string file_path = "../xml/sales.xml";
        public int Create(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Create Sale");
            XElement salesXml = XElement.Load(file_path);
            Sale s = item with { SaleCode = Config.NextSaleCode };
            XElement e = new XElement("Sale",
                new XElement("SaleCode", s.SaleCode),
                new XElement("ProductId", s.ProductId),
                new XElement("QuantityForSale", s.QuantityForSale),
                new XElement("SalePrice", s.SalePrice));
            if (s.IsClub != null)
            {
                e.Add(new XElement("IsClub", s.IsClub));
            }
            if (s.StartSale != null)
            {
                e.Add(new XElement("StartSale", s.StartSale));
            }
            if (s.EndSale != null)
            {
                e.Add(new XElement("EndSale", s.EndSale));
            }
            salesXml.Add(e);
            salesXml.Save(file_path);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Create Sale");
            return s.SaleCode;
        }
        /*public int Create(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start create sale");
            XElement saleXml = XElement.Load(file_path);
            Sale s = item with { SaleCode = Config.NextSaleCode };
            XElement e = new XElement("Sale",
                new XElement("SaleCode", s.SaleCode),
                new XElement("ProductId", s.ProductId),
                new XElement("QuantityForSale", s.QuantityForSale),
                new XElement("SalePrice", s.SalePrice)
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
        }*/



        public void Delete(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, " start delete sale");

            XElement xmlData = XElement.Load(file_path);
            List<Sale> sales = new List<Sale>();
            Sale SaleToDelete = sales.FirstOrDefault(s => s.ProductId == id);
            if (SaleToDelete != null)
            {
                sales.Remove(SaleToDelete);
                Config.SaveToXml(file_path, sales);
                LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "end delete sale");
            }
            else
            {
                throw new DO.DalIdDoesNotExist("Delete - ERROR: sale Id not exists");
            }
        }

        public Sale? Read(int id)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()!.Name, "read sale");
            List<Sale> sales = new List<Sale>();
            sales = Config.LoadFromXml<Sale>(file_path);
            Sale findSale = sales.FirstOrDefault(c => c.SaleCode == id);
            if (findSale != null)
            {
                return findSale;
            }
            throw new DO.DalIdDoesNotExist("Read - ERROR: sale Id not exists");


        }
        public Sale? Read(Func<Sale, bool> filter)
        {
             LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Read with filter Sale");
            try
            {
                List<Sale> sales = Config.LoadFromXml<Sale>(file_path);
                return sales.FirstOrDefault(filter);
            }
            catch (Exception)
            {
                throw new DO.DalNotFound("ERROR: There is no sale that meets the condition : Sale");
            }
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "ReadAll with filter Sale");
            List<Sale> sales = Config.LoadFromXml<Sale>(file_path);
            if (filter == null)
                return new List<Sale>(sales);
            return sales.Where(filter).ToList();
        }

        public void Update(Sale item)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "Start Update Sale");
            Delete(item.SaleCode);
            List<Sale> sales = Config.LoadFromXml<Sale>(file_path);
            sales.Add(item);
            Config.SaveToXml<Sale>( file_path, sales);
            LogManager.writeToLog(MethodBase.GetCurrentMethod()?.DeclaringType?.FullName!, MethodBase.GetCurrentMethod()?.Name!, "End Update Sale");
        }
    }
}
