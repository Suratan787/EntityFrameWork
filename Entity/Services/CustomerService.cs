using Entity.Data;
using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity.Services
{
    public interface ICustomerService
    {
        List<customer> GetAll();
        customer GetById(int Id);
        List<customer> GetByName(string Name);
        ResultModel Add(customer Data);
        ResultModel Edit(customer Data);
        ResultModel Delete(customer Data);
    }
    public class CustomerService : ICustomerService
    {
        private readonly CustomerContext _db;
        public CustomerService(CustomerContext db)
        {
            _db = db;
        }
        public ResultModel Add(customer Data)
        {
            ResultModel res = new ResultModel();
            try
            {
                Data.sex = "M";
                _db.Customer.Add(Data);
                _db.SaveChanges();
                res.Success = true;
            }
            catch(Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
        public ResultModel Delete(customer Data)
        {
            ResultModel res = new ResultModel();
            try
            {
                _db.Customer.Remove(Data);
                _db.SaveChanges();
                res.Success=true;  
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
        public ResultModel Edit(customer Data)
        {
            ResultModel res = new ResultModel();
            try
            {
                if(Data.id > 0)
                {
                    _db.Customer.Update(Data);
                    _db.SaveChanges();
                    res.Success = true;
                }
                else
                {
                    res.Success = false;
                    res.Message = "Data id is equre 0";
                }
            }
            catch(Exception ex)
            {
                res.Success = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
        public List<customer> GetAll()
        {
            return _db.Customer.ToList();

        }
        public customer GetById(int Id)
        {
            return _db.Customer.Where(p => p.id.Equals(Id)).FirstOrDefault();
        }
        public List<customer> GetByName(string Name)
        {
            return _db.Customer.Where(p => p.name1.Contains(Name)).ToList();
        }
    }
}
