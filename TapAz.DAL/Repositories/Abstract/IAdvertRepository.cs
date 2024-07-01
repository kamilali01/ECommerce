using TapAz.DAL.Entities;

namespace TapAz.DAL.Repositories.Abstract
{
    public interface IAdvertRepository
    {
        List<Advert> Get();
        Advert Get(int id);
        public void Add(Advert advert);
    }
}
