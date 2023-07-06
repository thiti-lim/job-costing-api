using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobCostingAPI.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        public CustomerController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _repo.GetCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _repo.GetCustomer(id);
            if (customer == null) return NotFound();
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            await _repo.InsertCustomer(customer);
            return Ok(await GetCustomers());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            var existingCustomer = await _repo.GetCustomer(customer.Id);
            if (existingCustomer == null) return NotFound(); 
            await _repo.UpdateCustomer(customer);
            return Ok(await GetCustomers());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _repo.GetCustomer(id);
            if (customer == null) return NotFound(); 
            await _repo.DeleteCustomer(id);
            return Ok(await GetCustomers());
        }


    }
}
