using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ICustomerRepository
    {
        Task DeleteCustomer(int id);
        Task<Customer?> GetCustomer(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task InsertCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
    }
}
