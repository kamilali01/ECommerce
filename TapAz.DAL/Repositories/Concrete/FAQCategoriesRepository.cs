using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class FAQCategoriesRepository : IFAQCategoriesRepository
    {
        private readonly AppDBContext _ctx;

        public FAQCategoriesRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(FAQCategories entity)
        {
            _ctx.FAQCategories.Add(entity);
        }

        public List<FAQCategories> Get()
        {
            return _ctx.FAQCategories.ToList();
        }
        public FAQCategories Get(int id)
        {
            return _ctx.FAQCategories.First(a => a.Id == id);
        }
    }
}
