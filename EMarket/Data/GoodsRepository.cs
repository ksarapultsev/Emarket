using EMarket.Models;

namespace EMarket.Data
{
    public class GoodsRepository
    {
        private ApplicationDbContext _context;

        public GoodsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Categories> GetAllCategories()
        {
            var categories = _context.Categories.ToList();

            return categories;
        }
    }
}
