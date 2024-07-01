using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapAz.DAL.Contexts;
using TapAz.DAL.Entities;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.Repositories.Concrete
{
    public class AdsRepository : IAdsRepository
    {
        private readonly AppDBContext _ctx;

        public AdsRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Ads ad)
        {
            _ctx.Ads.Add(ad);
        }

        public List<Ads> Get()
        {
            return _ctx.Ads.ToList();
        }

        public Ads Get(int id)
        {
            return _ctx.Ads.First(b => b.Id == id);
        }
    }

}
