namespace TapAz.BLL.Services.Concrete;

public class PremiumManager : IPremiumService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PremiumManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<PremiumGetDto> GetAll()
    {
        List<Premium> premiums = _unitOfWork.PremiumRepository.Get();
        if (premiums is null)
        {
            return new List<PremiumGetDto> { new PremiumGetDto() };
        }
        return new List<PremiumGetDto>(_mapper.Map<List<PremiumGetDto>>(premiums));
    }

    public PremiumGetDto GetById(int id)
    {
        Premium premium = _unitOfWork.PremiumRepository.Get(id);
        if (premium is null)
        {
            return new PremiumGetDto();
        }
        PremiumGetDto mappedEntity = _mapper.Map<PremiumGetDto>(premium);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(PremiumPostDto dto)
    {
        Premium premium = _mapper.Map<Premium>(dto);
        _unitOfWork.PremiumRepository.Add(premium);
        _unitOfWork.Save();
    }
    #endregion
}