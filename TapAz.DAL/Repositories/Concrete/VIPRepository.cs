using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class VIPRepository : IVIPRepository
    {
        private readonly AppDBContext _ctx;

        public VIPRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(VIP entity)
        {
            _ctx.VIPs.Add(entity);
        }

        public List<VIP> Get()
        {
            return _ctx.VIPs.ToList();
        }
        public VIP Get(int id)
        {
            return _ctx.VIPs.First(a => a.Id == id);
        }
    }
}
