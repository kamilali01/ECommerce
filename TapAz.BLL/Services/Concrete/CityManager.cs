namespace TapAz.BLL.Services.Concrete;

public class CityManager : ICityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CityManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Get Requests
    public List<CityGetDto> GetAll()
    {
        List<City> cities = _unitOfWork.CityRepository.Get();
        if (cities is null)
        {
            return new List<CityGetDto> { new CityGetDto() };
        }
        return new List<CityGetDto>(_mapper.Map<List<CityGetDto>>(cities));
    }

    public CityGetDto GetById(int id)
    {
        City city = _unitOfWork.CityRepository.Get(id);
        if (city is null)
        {
            return new CityGetDto();
        }
        CityGetDto mappedEntity = _mapper.Map<CityGetDto>(city);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(CityPostDto dto)
    {
        City city = _mapper.Map<City>(dto);
        _unitOfWork.CityRepository.Add(city);
        _unitOfWork.Save();
    }
    #endregion
}
