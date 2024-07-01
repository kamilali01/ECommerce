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
    public class UserRepository:IUserRepository
    {
        private readonly AppDBContext _ctx;

        public UserRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(User user)
        {
            _ctx.Users.Add(user);
        }

        public List<User> Get()
        {
            return _ctx.Users.ToList();
        }

        public User Get(int id)
        {
            return _ctx.Users.First(a => a.Id == id);
        }
    }
}
