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
    public class FAQRepository:IFAQRepository
    {
        private readonly AppDBContext _ctx;

        public FAQRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(FAQ faq)
        {
            _ctx.FAQs.Add(faq);
        }

        public List<FAQ> Get()
        {
            return _ctx.FAQs.ToList();
        }

        public FAQ Get(int id)
        {
            return _ctx.FAQs.First(a => a.Id == id);
        }
    }
}
