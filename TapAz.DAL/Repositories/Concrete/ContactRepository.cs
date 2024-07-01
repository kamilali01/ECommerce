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
    public class ContactRepository: IContactRepository
    {
        private readonly AppDBContext _ctx;

        public ContactRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(Contact contact)
        {
            _ctx.Contacts.Add(contact);
        }

        public List<Contact> Get()
        {
            return _ctx.Contacts.ToList();
        }

        public Contact Get(int id)
        {
            return _ctx.Contacts.First(a => a.Id == id);
        }
    }
}
