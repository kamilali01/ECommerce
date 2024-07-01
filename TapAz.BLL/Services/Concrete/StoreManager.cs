namespace TapAz.BLL.Services.Concrete;

public class StoreManager : IStoreService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _env;
    private readonly IMapper _mapper;

    public StoreManager(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment env)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _env = env;
    }
    #region Get Requests
    public List<StoreGetDto> GetAll()
    {
        List<Store> stores = _unitOfWork.StoreRepository.Get();
        if (stores is null)
        {
            return new List<StoreGetDto> { new StoreGetDto() };
        }
        return new List<StoreGetDto>(_mapper.Map<List<StoreGetDto>>(stores));
    }

    public StoreGetDto GetById(int id)
    {
        Store store = _unitOfWork.StoreRepository.Get(id);
        if (store is null)
        {
            return new StoreGetDto();
        }
        StoreGetDto mappedEntity = _mapper.Map<StoreGetDto>(store);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(StorePostDto dto)
    {
        Store store = _mapper.Map<Store>(dto);
        store.PicPath = dto.PicPath.FileCreate(_env.WebRootPath, "uploads/ads");
        _unitOfWork.StoreRepository.Add(store);
        _unitOfWork.Save();
    }
    #endregion
}
