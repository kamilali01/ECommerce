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
    public class ParameterRepository:IParameterRepository
    {
        private readonly AppDBContext _ctx;

        public ParameterRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Parameter faq)
        {
            _ctx.Parameters.Add(faq);
        }

        public List<Parameter> Get()
        {
            return _ctx.Parameters.ToList();
        }

        public Parameter Get(int id)
        {
            return _ctx.Parameters.First(a => a.Id == id);
        }
    }
}
