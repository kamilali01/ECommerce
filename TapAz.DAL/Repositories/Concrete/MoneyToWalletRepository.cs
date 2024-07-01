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
    public class MoneyToWalletRepository:IMoneyToWalletRepository
    {
        private readonly AppDBContext _ctx;

        public MoneyToWalletRepository(AppDBContext context)
        {
            _ctx = context;
        }

        public void Add(MoneyToWallet moneyToWallet)
        {
            _ctx.MoneyToWallets.Add(moneyToWallet);
        }

        public List<MoneyToWallet> Get()
        {
            return _ctx.MoneyToWallets.ToList();
        }

        public MoneyToWallet Get(int id)
        {
            return _ctx.MoneyToWallets.First(a => a.Id == id);
        }
    }
}
