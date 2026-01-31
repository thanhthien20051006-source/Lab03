using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;
using ECommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ECommerceDbContext _dbContext;
        public CustomerRepository(ECommerceDbContext dbContext) => _dbContext = dbContext;

        public async Task<Customer?> GetByIdAsync(int id)
            => await _dbContext.Customers
                               .Include(c => c.Address)
                               .FirstOrDefaultAsync(c => c.Id == id);

        public async Task AddAsync(Customer customer)
        {
            await _dbContext.Customers.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}

