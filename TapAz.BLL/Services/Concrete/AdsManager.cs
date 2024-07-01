namespace TapAz.BLL.Services.Concrete;

public class AdsManager : IAdsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _env;
    private readonly IMapper _mapper;

    public AdsManager(IUnitOfWork unitOfWork, IMapper mapper,IWebHostEnvironment env)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _env = env;
    }

    #region Get Requests
    public List<AdsGetDto> GetAll()
    {
        List<Ads> ads = _unitOfWork.AdsRepository.Get();
        if (ads is null)
        {
            return new List<AdsGetDto> { new AdsGetDto() };
        }
        return new List<AdsGetDto>(_mapper.Map<List<AdsGetDto>>(ads));
    }

    public AdsGetDto GetById(int id)
    {
        Ads ad = _unitOfWork.AdsRepository.Get(id);
        if (ad is null)
        {
            return new AdsGetDto();
        }
        AdsGetDto mappedEntity = _mapper.Map<AdsGetDto>(ad);
        return mappedEntity;
    }

    #endregion

    #region Post Request
    public void Create(AdsPostDto dto)
    {
        Ads ad = _mapper.Map<Ads>(dto);
        ad.PicPath = dto.PicPath.FileCreate(_env.WebRootPath, "uploads/ads");
        _unitOfWork.AdsRepository.Add(ad);
        _unitOfWork.Save();
    }

    #endregion

}