using Microsoft.AspNetCore.Identity;

namespace TapAz.DAL.Entities
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public int Wallet { get; set; }
        public List<Advert>? Selected { get; set; }
        public List<Advert> Adverts { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
