
using BlApi;
using BO;
using static BO.Exceptions;

namespace BlImplementation
{
    internal class OrderImplamention : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        
        
        public void CalcTotalPriceForProduct(BO.ProductInOrder product)
        {
            List<BO.SaleInProduct> currentSales = new List<BO.SaleInProduct>();
            if (product.Sales.Count() == 0)
            {
                product.FinalPrice = product.Quantity * product.Price;
            }
            else {
                int count = product.Quantity;
                foreach (var sale in product.Sales.OrderBy(s => s.Quantity))
                {   
                    if(count == 0)
                        break;
                    if (sale.Quantity <= count)
                    {
                        currentSales.Add(sale);
                        product.FinalPrice = sale.Price * (count / sale.Quantity);
                        count = count % sale.Quantity;
                    }
                    else
                        continue;
                }
                product.FinalPrice += product.Price * count;
                product.Sales=currentSales;
            }
        }

        public void CalcTotalPrice(BO.Order order)
        {
            order.TotalPrice = order.ProductsInOrder.Select(s => s.FinalPrice).Sum();
        }

       public List<SaleInProduct> AddProductToOrder(BO.Order order, int productId, int countInOrder)
        {
            DO.Product p1 = _dal.Product.Read(productId);
            if (p1 == null)
            {
                throw new BlDoesNotExistException("NOT FOUND PRODUCT");
            }
            if ( p1.convertDoToBo().Quantity - countInOrder < 0)
            {
                throw new BlOutOfStockExistException("there is not enough  in stock");
            }
            BO.ProductInOrder p2 = order.ProductsInOrder.FirstOrDefault(p => p.ProductId == productId);
            ProductInOrder productInOrder;
            if ( p2== null)
            {
                 productInOrder = new ProductInOrder(productId, p1.convertDoToBo().ProductName,
                 p1.convertDoToBo().Price, countInOrder);
                order.ProductsInOrder.Add(productInOrder);
          
            }
            else
            {
                productInOrder = p2;
                productInOrder.Quantity = countInOrder;
            }
            SearchSaleForProduct(productInOrder);
            CalcTotalPriceForProduct(productInOrder);
            CalcTotalPrice(order);
            return productInOrder.Sales;
        }
        //c#

        public void DoOrder(BO.Order order)
        {
            try
            {
                foreach (var p in order.ProductsInOrder)
                {
                    Product p1 = _dal.Product.Read(p.ProductId).convertDoToBo();
                    p1.Quantity -= p.Quantity;
                    _dal.Product.Update(p1.convertBoToDo());
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void SearchSaleForProduct(ProductInOrder product)
        {
            //product.Sales = _dal.Sale.ReadAll(s => s.ProductId == product.ProductId && s.convertDOtoBO().isValidSale()
            //                && s.QuantityForSale <= product.Quantity ).OrderBy(s => s.SalePrice / s.QuantityForSale)
            //                .Select(s => new SaleInProduct(s.SaleCode,s.QuantityForSale,s.SalePrice)).ToList();

            product.Sales = _dal.Sale.ReadAll(s => s.ProductId == product.ProductId
                                        && s.convertDOtoBO().isValidSale()
                                        && product.Quantity >= s.QuantityForSale)
                                        .OrderBy(s => s?.SalePrice / s?.QuantityForSale)
                                        .Select(s => new SaleInProduct(s!.SaleCode, s.QuantityForSale, s.SalePrice)).ToList();
        }

        public void DeleteProductFromOrder(Order order, int productId)
        {
            ProductInOrder productToDelet = order.ProductsInOrder.Find(p =>p.ProductId ==productId);
            order.TotalPrice -= productToDelet.FinalPrice;
            order.ProductsInOrder.Remove(productToDelet);
        }


        //List<SaleInProduct> IOrder.AddProductToOrder(Order order, int productId, int countInOrder)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
