using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class AdvertRepository : IAdvertRepository
    {
        private readonly AppDBContext _ctx;

        public AdvertRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Advert advert)
        {
            _ctx.Adverts.Add(advert);
        }

        public List<Advert> Get()
        {
            return _ctx.Adverts.ToList();
        }

        public Advert Get(int id)
        {
            return _ctx.Adverts.First(a => a.Id == id);
        }
    }

}
