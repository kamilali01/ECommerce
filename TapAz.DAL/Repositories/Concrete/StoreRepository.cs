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
    public class StoreRepository:IStoreRepository
    {
        private readonly AppDBContext _ctx;

        public StoreRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Store store)
        {
            _ctx.Stores.Add(store);
        }

        public List<Store> Get()
        {
            return _ctx.Stores.ToList();
        }

        public Store Get(int id)
        {
            return _ctx.Stores.First(a => a.Id == id);
        }
    }
}
