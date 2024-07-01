namespace BusinessLogicLayer.Utilities.Profiles;

public class Mapper : Profile
{
    public Mapper()
    {
        //Ads
        CreateMap<Ads, AdsGetDto>();
        CreateMap<AdsPostDto, Ads>();
        CreateMap<AdsUpdateDto, Ads>();
        CreateMap<AdsGetDto, AdsUpdateDto>();

        //Advert
        CreateMap<Advert, AdvertGetDto>();
        CreateMap<AdvertPostDto, Advert>();
        CreateMap<AdvertUpdateDto, Advert>();
        CreateMap<AdvertGetDto, AdvertUpdateDto>();

        //AdvertQuestion
        CreateMap<AdvertQuestion, AdvertQuestionGetDto>();
        CreateMap<AdvertQuestionPostDto, AdvertQuestion>();
        CreateMap<AdvertQuestionUpdateDto, AdvertQuestion>();
        CreateMap<AdvertQuestionGetDto, AdvertQuestionUpdateDto>();

        //Category
        CreateMap<Category, CategoryGetDto>();
        CreateMap<CategoryPostDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();
        CreateMap<CategoryGetDto, CategoryUpdateDto>();

        //City
        CreateMap<City, CityGetDto>();
        CreateMap<CityPostDto, City>();
        CreateMap<CityUpdateDto, City>();
        CreateMap<CityGetDto, CityUpdateDto>();

        //Contact
        CreateMap<Contact, ContactGetDto>();
        CreateMap<ContactPostDto, Contact>();
        CreateMap<ContactUpdateDto, Contact>();
        CreateMap<ContactGetDto, ContactUpdateDto>();

        //FAQ
        CreateMap<FAQ, FAQGetDto>();
        CreateMap<FAQPostDto, FAQ>();
        CreateMap<FAQUpdateDto, FAQ>();
        CreateMap<FAQGetDto, FAQUpdateDto>();

        //FAQCategories
        CreateMap<FAQCategories, FAQCategoriesGetDto>();
        CreateMap<FAQCategoriesPostDto, FAQCategories>();
        CreateMap<FAQCategoriesUpdateDto, FAQCategories>();
        CreateMap<FAQCategoriesGetDto, FAQCategoriesUpdateDto>();

        //MoneyToWallet
        CreateMap<MoneyToWallet, MoneyToWalletGetDto>();
        CreateMap<MoneyToWalletPostDto, MoneyToWallet>();
        CreateMap<MoneyToWalletUpdateDto, MoneyToWallet>();
        CreateMap<MoneyToWalletGetDto, MoneyToWalletUpdateDto>();

        //Parameter
        CreateMap<Parameter, ParameterGetDto>();
        CreateMap<ParameterPostDto, Parameter>();
        CreateMap<ParameterUpdateDto, Parameter>();
        CreateMap<ParameterGetDto, ParameterUpdateDto>();

        //Premium
        CreateMap<Premium, PremiumGetDto>();
        CreateMap<PremiumPostDto, Premium>();
        CreateMap<PremiumUpdateDto, Premium>();
        CreateMap<PremiumGetDto, PremiumUpdateDto>();

        //Store
        CreateMap<Store, StoreGetDto>();
        CreateMap<StorePostDto, Store>();
        CreateMap<StoreUpdateDto, Store>();
        CreateMap<StoreGetDto, StoreUpdateDto>();

        //User
        CreateMap<User, UserGetDto>();
        CreateMap<UserPostDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<UserGetDto, UserUpdateDto>();

        //VIP
        CreateMap<VIP, VIPGetDto>();
        CreateMap<VIPPostDto, VIP>();
        CreateMap<VIPUpdateDto, VIP>();
        CreateMap<VIPGetDto, VIPUpdateDto>();
    }
}
