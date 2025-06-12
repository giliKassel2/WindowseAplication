using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BO;

public class Order { 

    public CustomerPreference Preference { get; set; }
    public List<ProductInOrder> ProductsInOrder { get; set; }
    
    public double TotalPrice { get; set; }
    
    //public void SetQuantity()
    //{

    //}

    public Order(CustomerPreference Preference, double TotalPrice)
    {
        this.Preference = Preference;
        this.ProductsInOrder = new List<ProductInOrder>();
        this.TotalPrice = TotalPrice;

    }

    public Order(CustomerPreference preference)
    {
        this.Preference = preference;
        this.ProductsInOrder = new List<ProductInOrder>();
        this.TotalPrice = 0;

    }

}

