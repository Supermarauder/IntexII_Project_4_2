
namespace IntexII_Project_4_2.Models
{
    public class EFIntexProjectRepository : IIntexProjectRepository
    {
        private IntexProjectDbContext _context;
        public EFIntexProjectRepository(IntexProjectDbContext temp) 
        {
            _context = temp;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}
