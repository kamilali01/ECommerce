using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDBContext _ctx;

        public CityRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(City entity)
        {
            _ctx.Cities.Add(entity);
        }

        public List<City> Get()
        {
            return _ctx.Cities.ToList();
        }
        public City Get(int id)
        {
            return _ctx.Cities.First(a => a.Id == id);
        }
    }
}
