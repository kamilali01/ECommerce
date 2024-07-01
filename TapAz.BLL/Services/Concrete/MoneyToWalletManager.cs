namespace TapAz.BLL.Services.Concrete;

public class MoneyToWalletManager : IMoneyToWalletService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public MoneyToWalletManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<MoneyToWalletGetDto> GetAll()
    {
        List<MoneyToWallet> moneyToWallets = _unitOfWork.MoneyToWalletRepository.Get();
        if (moneyToWallets is null)
        {
            return new List<MoneyToWalletGetDto> { new MoneyToWalletGetDto() };
        }
        return new List<MoneyToWalletGetDto>(_mapper.Map<List<MoneyToWalletGetDto>>(moneyToWallets));
    }

    public MoneyToWalletGetDto GetById(int id)
    {
        MoneyToWallet moneyToWallet = _unitOfWork.MoneyToWalletRepository.Get(id);
        if (moneyToWallet is null)
        {
            return new MoneyToWalletGetDto();
        }
        MoneyToWalletGetDto mappedEntity = _mapper.Map<MoneyToWalletGetDto>(moneyToWallet);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(MoneyToWalletPostDto dto)
    {
        MoneyToWallet moneyToWallet = _mapper.Map<MoneyToWallet>(dto);
        _unitOfWork.MoneyToWalletRepository.Add(moneyToWallet);
        _unitOfWork.Save();
    }
    #endregion
}
