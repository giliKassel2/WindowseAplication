using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class ProductInOrder
{
    public int ProductId {  get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public  int Quantity {get; set; }

    public List<SaleInProduct> Sales { get; set; }
    public double FinalPrice { get; set; }
    public int CountInOrder { get; }

    ProductInOrder(int ProductId,string ProductName,double Price,int Quantity,List<SaleInProduct> Sales, double FinalPrice)
{
    this.ProductId = ProductId;
    this.ProductName = ProductName;
    this.Price = Price;
    this.Quantity = Quantity;
    this.Sales = Sales;
    this.FinalPrice = FinalPrice;
}

    public ProductInOrder(int productId, string productName, double price, int countInOrder)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        CountInOrder = countInOrder;
    }
}