namespace TapAz.BLL.Services.Concrete;

public class AdvertManager : IAdvertService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _env;
    private readonly IMapper _mapper;

    public AdvertManager(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment env)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _env = env;
    }


    #region Get Requests
    public List<AdvertGetDto> GetAll()
    {
        List<Advert> adverts = _unitOfWork.AdvertRepository.Get();
        if (adverts is null)
        {
            return new List<AdvertGetDto> { new AdvertGetDto() };
        }
        return new List<AdvertGetDto>(_mapper.Map<List<AdvertGetDto>>(adverts));
    }

    public AdvertGetDto GetById(int id)
    {
        Advert advert = _unitOfWork.AdvertRepository.Get(id);
        if (advert is null)
        {
            return new AdvertGetDto();
        }
        AdvertGetDto mappedEntity = _mapper.Map<AdvertGetDto>(advert);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(AdvertPostDto dto)
    {
        Advert advert = _mapper.Map<Advert>(dto);
        advert.PhotoPath = dto.PhotoPath.FileCreate(_env.WebRootPath, "uploads/advert");
        _unitOfWork.AdvertRepository.Add(advert);
        _unitOfWork.Save();
    }
    #endregion

}
