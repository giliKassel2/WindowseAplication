﻿
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
                return _dal.Customer.Create(item.ConvertBOtoDO());
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
                _dal.Customer.Delete(id);
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
                DO.Customer customer = _dal.Customer.Read(id);
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
                DO.Customer customer = _dal.Customer.Read(id);
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
                return _dal.Customer.Read(doCustomer => filter(doCustomer.ConvertDOtoBO()))?.ConvertDOtoBO();
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
                if (filter == null)
                {
                    return _dal.Customer.ReadAll().Select(s => s.ConvertDOtoBO()).ToList();
                }
                return _dal.Customer.ReadAll(doCustomer => filter(doCustomer.ConvertDOtoBO())).Select(s => s.ConvertDOtoBO()).ToList();
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
                _dal.Customer.Update(item.ConvertBOtoDO());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
