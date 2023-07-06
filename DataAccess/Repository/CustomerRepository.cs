using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ISqlDataAccess _db;

        public CustomerRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {

        var results = _db.LoadData<Customer, dynamic>(
            storedProcedure: "dbo.p_customer_get_all",
            new { });
            return results; 

        } 
        

        public async Task<Customer?> GetCustomer(int id)
        {

            var results = await _db.LoadData<Customer, dynamic>(
                storedProcedure: "dbo.p_customer_get",
                new { id });
            return results.FirstOrDefault();
        }

        public Task InsertCustomer(Customer customer) => _db.SaveData(
            storedProcedure: "dbo.p_customer_insert",
            new { name = customer.Name, location = customer.Location, contact = customer.Contact, phone_number = customer.PhoneNumber });

        public Task UpdateCustomer(Customer customer) => _db.SaveData(storedProcedure: "dbo.p_customer_update", new { id = customer.Id, name = customer.Name, location = customer.Location, contact = customer.Contact, phone_number = customer.PhoneNumber });

        public Task DeleteCustomer(int id) => _db.SaveData(storedProcedure: "dbo.p_customer_delete",new { id });
    }
}
