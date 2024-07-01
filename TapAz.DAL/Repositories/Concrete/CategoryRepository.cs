using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDBContext _ctx;

        public CategoryRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Category entity)
        {
            _ctx.Categories.Add(entity);
        }

        public List<Category> Get()
        {
            return _ctx.Categories.ToList();
        }
        public Category Get(int id)
        {
            return _ctx.Categories.First(a => a.Id == id);
        }
    }
}
