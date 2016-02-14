using System.Collections.Generic;
using System.Linq;
using CustomerWebApi.DAL;
using CustomerWebApi.DAL.Entities;
using Microsoft.AspNet.Mvc;

namespace CustomerWebApi.Controllers
{

    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IRepository repository;

        public CustomerController(IRepository customerRepository)
        {
            repository = customerRepository;
        }
        
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return repository.GetCustomers().ToList();
        }

        // GET api/Customer/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return repository.GetCustomerByID(id);
        }

        // POST api/Customer
        [HttpPost]
        public void Post([FromBody]Customer customer)
        {
            repository.InsertCustomer(customer);
            repository.Save();
        }

        // PUT api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Customer customer)
        {
            repository.UpdateCustomer(customer);
            repository.Save();
        }

        // DELETE api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteCustomer(id);
        }
    }
}