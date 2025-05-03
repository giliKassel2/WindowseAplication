using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLApi;
using static BO.Exceptions;
using static BO.Tools;



namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.product.Create(item.convertBoToDo());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.product.Read(id).convertDoToBo();
            }
            catch (Exception e)
            {
                throw new BlDoesNotExistException(e.Message);
            }
        }
        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.product.Read(p => filter(p.convertDoToBo()))?.convertDoToBo();
            }
            catch (Exception e)
            {
                throw new BlNotFound(e.Message);
            }
        }
        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                return _dal.product.ReadAll(p => filter(p.convertDoToBo())).Select(p => p.convertDoToBo()).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Update(BO.Product item)
        {
            try
            {
                _dal.product.Update(item.convertBoToDo());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Delete(int id)
        {
             try
            {
                _dal.product.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public List<BO.SaleInProduct> GetAllCurrentSales(int productId, BO.CustomerPreference preference)
        {
            try
            {
                return Read(productId).Sales.Where(s => s.Preference == preference && _dal.sale.Read(s.SaleId).convertDOtoBO().isValidSale()).Select(s=> s).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
       
    }
}
