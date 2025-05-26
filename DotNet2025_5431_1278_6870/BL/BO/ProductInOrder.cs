using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DO;

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

    public ProductInOrder(int productId, string productName, double price, int countInOrder)
    {
        this.ProductId = productId;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity =countInOrder ;
        this.Sales = new List<SaleInProduct>();
        this.FinalPrice = 0;
        
    }

    public String ToString() { return $" name: {ProductName} \n quantity: {Quantity} \n price: {Price} \n id: {ProductId} "; }
}