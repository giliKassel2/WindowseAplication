
using BlApi;
using static BO.Exceptions;
using static BO.Tools;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {  
                return _dal.customer.Create(item.ConvertBOtoDO());
            }
            catch (DO.DalIdAlreadyExists ex)
            {
                throw new BllIdAlreadyExists(ex.Message);
            }
            catch (Exception ex) 
            {
                    throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.customer.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsExist(int id)
        {
            try
            {
                DO.Customer customer = _dal.customer.Read(id);
                if (customer == null) 
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                DO.Customer customer = _dal.customer.Read(id);
                return customer?.ConvertDOtoBO();
            }
            catch (Exception ex)
            {
                throw new BlDoesNotExistException(ex.Message);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool>? filter)
        {
            try
            {
                return _dal.customer.Read(doCustomer => filter(doCustomer.ConvertDOtoBO()))?.ConvertDOtoBO();
            }
            catch (Exception ex)
            {
                throw new BlNotFound(ex.Message);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                return _dal.customer.ReadAll(doCustomer => filter(doCustomer.ConvertDOtoBO())).Select(s => s.ConvertDOtoBO()).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.customer.Update(item.ConvertBOtoDO());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
