using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapAz.DAL.Repositories.Abstract;

namespace TapAz.DAL.UnitofWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAdsRepository AdsRepository { get; }
        IAdvertRepository AdvertRepository { get; }
        IAdvertQuestionRepository AdvertQuestionRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICityRepository CityRepository { get; }
        IContactRepository ContactRepository { get; }
        IFAQRepository FAQRepository { get; }
        IFAQCategoriesRepository FAQCategoriesRepository { get; }
        IMoneyToWalletRepository MoneyToWalletRepository { get; }
        IParameterRepository ParameterRepository { get; }
        IPremiumRepository PremiumRepository { get; }
        IStoreRepository StoreRepository { get; }
        IUserRepository UserRepository { get; }
        IVIPRepository VIPRepository { get; }
        // Other repositories can be added here if needed

        void Save();
    }

}
