using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BO;
using static BO.Tools;
namespace BO;

static internal class Tools
{
    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();
        Type t = obj?.GetType() ?? throw new Exception("Obj is NULL");
        foreach (PropertyInfo prop in t.GetProperties())
        {
            if (prop.PropertyType.IsPrimitive
                || prop.PropertyType == typeof(string)
                || prop.PropertyType == typeof(DateTime))
                sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
            else
                sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
        }
        return sb.ToString();
    }

    public static bool isValidSale(this Sale sale)
    {

        if (sale.StartSale == null) return false;
        return sale.StartSale <= DateTime.Now && sale.EndSale >= DateTime.Now;
    }
  
    public static BO.Product convertDoToBo(this DO.Product p)
    {
        {
            return new BO.Product( p.ProductCode, p.ProductName, p.Price, p.Quantity,(BO.Categories?)p.Category);
        }
    }
    public static DO.Product convertBoToDo(this BO.Product p)
    {
        {
            return new DO.Product(p.ProductCode, p.ProductName, p.Price, p.Quantity, (DO.Categories?)p.Category);
        }
    }
    public static BO.Sale convertDOtoBO(this DO.Sale obj)
    {
        return new BO.Sale(obj.SaleCode, obj.ProductId, obj.QuantityForSale, obj.SalePrice, obj.IsClub, obj.StartSale, obj.EndSale);
    }

    public static DO.Sale convertBOtoDO(this BO.Sale obj)
    {
        return new DO.Sale(obj.SaleCode, obj.ProductId, obj.QuantityForSale, obj.SalePrice, obj.IsClub, obj.StartSale, obj.EndSale);
    }

    public static BO.Customer ConvertDOtoBO(this DO.Customer c)
    {
        return new BO.Customer(c.Id, c.Name, c.Adress, c.PhoneNumber);
    }
    public static DO.Customer ConvertBOtoDO(this BO.Customer c)
    {
        return new DO.Customer(c.Id, c.Name, c.Adress, c.PhoneNumber);
    }
}
