using TapAz.DAL.Contexts;
using TapAz.DAL.Repositories.Abstract;
using TapAz.DAL.Repositories.Concrete;
using TapAz.DAL.UnitofWork.Abstract;

namespace TapAz.DAL.UnitofWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _ctx;

        public UnitOfWork(AppDBContext context)
        {
            _ctx = context;
            AdsRepository = new AdsRepository(_ctx);
            AdvertRepository = new AdvertRepository(_ctx);
            AdvertQuestionRepository = new AdvertQuestionRepository(_ctx);
            CategoryRepository = new CategoryRepository(_ctx);
            CityRepository = new CityRepository(_ctx);
            ContactRepository = new ContactRepository(_ctx);
            FAQRepository = new FAQRepository(_ctx);
            FAQCategoriesRepository = new FAQCategoriesRepository(_ctx);
            MoneyToWalletRepository = new MoneyToWalletRepository(_ctx);
            ParameterRepository = new ParameterRepository(_ctx);
            PremiumRepository = new PremiumRepository(_ctx);
            StoreRepository = new StoreRepository(_ctx);
            UserRepository = new UserRepository(_ctx);
            VIPRepository = new VIPRepository(_ctx);
            // Other repositories can be initialized here if needed.
        }

        public IAdsRepository AdsRepository { get; private set; }

        public IAdvertRepository AdvertRepository { get; private set; }
        public IAdvertQuestionRepository AdvertQuestionRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public ICityRepository CityRepository { get; private set; }
        public IContactRepository ContactRepository { get; private set; }
        public IFAQRepository FAQRepository { get; private set; }
        public IFAQCategoriesRepository FAQCategoriesRepository { get; private set; }
        public IMoneyToWalletRepository MoneyToWalletRepository { get; private set; }
        public IParameterRepository ParameterRepository { get; private set; }
        public IPremiumRepository PremiumRepository { get; private set; }
        public IStoreRepository StoreRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }
        public IVIPRepository VIPRepository { get; private set; }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }

}
