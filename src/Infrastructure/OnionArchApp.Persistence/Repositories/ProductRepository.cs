using OnionArchApp.Application.Interfaces.Repository;
using OnionArchApp.Domain.Entities;
using OnionArchApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchApp.Persistence.Repositories
{
    public class ProductRepository: GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
