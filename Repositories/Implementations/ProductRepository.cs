using CRUDWithRepository.Data;
using CRUDWithRepository.Models;

namespace CRUDWithRepository.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }
    }
}
