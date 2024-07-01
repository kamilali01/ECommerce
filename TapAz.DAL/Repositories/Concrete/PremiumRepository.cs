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
    public class PremiumRepository : IPremiumRepository
    {
        private readonly AppDBContext _ctx;

        public PremiumRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Premium entity)
        {
            _ctx.Premiums.Add(entity);
        }

        public List<Premium> Get()
        {
            return _ctx.Premiums.ToList();
        }
        public Premium Get(int id)
        {
            return _ctx.Premiums.First(a => a.Id == id);
        }
    }
}
