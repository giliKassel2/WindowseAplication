using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId {  get; set; }
        public int Quantity {  get; set; }
        public double Price { get; set; }
        public CustomerPreference Preference { get; set; }
        
        public SaleInProduct( int SaleId,int Quantity,double Price,CustomerPreference Preference=BO.CustomerPreference.CUSTOMER)
        {
            this.SaleId = SaleId;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        public string toString()
        {
            return "quantity: " + Quantity + "in price :" + Price;
        }

    }

    
}

