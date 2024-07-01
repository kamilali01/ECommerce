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
    public class AdvertQuestionRepository:IAdvertQuestionRepository
    {
        private readonly AppDBContext _ctx;

        public AdvertQuestionRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(AdvertQuestion advertQuestion)
        {
            _ctx.AdvertQuestions.Add(advertQuestion);
        }

        public List<AdvertQuestion> Get()
        {
            return _ctx.AdvertQuestions.ToList();
        }

        public AdvertQuestion Get(int id)
        {
            return _ctx.AdvertQuestions.First(b => b.Id == id);
        }
    }
}
