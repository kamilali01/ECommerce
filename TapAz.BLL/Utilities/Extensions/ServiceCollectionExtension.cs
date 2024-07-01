using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TapAz.BLL.Utilities.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddBusinnessConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddFluentValidationAutoValidation(opt =>
        //{
        //    opt.DisableDataAnnotationsValidation = false;
        //}).AddFluentValidationClientsideAdapters();
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<AppDBContext>()
        .AddDefaultTokenProviders();

        var jwtSettings = configuration.GetSection("JwtSettings");
        var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero
            };
        });

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IAdvertService, AdvertManager>();
        services.AddScoped<IAdsService, AdsManager>();
        services.AddScoped<IAdvertQuestionService, AdvertQuestionManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICityService, CityManager>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IFAQService, FAQManager>();
        services.AddScoped<IFAQCategoriesService, FAQCategoriesManager>();
        services.AddScoped<IMoneyToWalletService, MoneyToWalletManager>();
        services.AddScoped<IParameterService, ParameterManager>();
        services.AddScoped<IPremiumService, PremiumManager>();
        services.AddScoped<IUserService, UserManager>();
        services.AddScoped<IStoreService, StoreManager>();
        services.AddScoped<IVIPService, VIPManager>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddDbContext<AppDBContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("Default"));

        });
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        
        return services;
    }
}
