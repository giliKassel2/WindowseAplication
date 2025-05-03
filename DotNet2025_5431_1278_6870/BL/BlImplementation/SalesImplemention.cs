
using BlApi;
using BO;
using DO;
using static BO.Exceptions;

namespace BlImplementation;


internal class SalesImplemention : ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Sale item)
    {
       try
        {
            return _dal.sale.Create(item.convertBOtoDO());
        }
        catch(Exception e){
            throw new Exception(e.Message);
        }
    }
    public BO.Sale? Read(int id)
    {
        try
        {
            return _dal.sale.Read(id).convertDOtoBO();
        }
        catch (Exception e)
        {
            throw new BlDoesNotExistException(e.Message);
        }
    }
    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try
        {
            return _dal.sale.Read(p => filter(p.convertDOtoBO()))?.convertDOtoBO();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
    {
        try
        {
            return _dal.sale.ReadAll(s => filter(s.convertDOtoBO())).Select(s => s.convertDOtoBO()).ToList();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    public void Update(BO.Sale item)
    {
        try
        {
            _dal.sale.Update(item.convertBOtoDO());
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
            _dal.sale.Delete(id);
        }
        catch (Exception e)
        {
            throw new BlNotFound(e.Message);
        }

    }
   

}

