namespace TapAz.BLL.Services.Concrete;

public class VIPManager : IVIPService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public VIPManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<VIPGetDto> GetAll()
    {
        List<VIP> vips = _unitOfWork.VIPRepository.Get();
        if (vips is null)
        {
            return new List<VIPGetDto> { new VIPGetDto() };
        }
        return new List<VIPGetDto>(_mapper.Map<List<VIPGetDto>>(vips));
    }

    public VIPGetDto GetById(int id)
    {
        VIP vip = _unitOfWork.VIPRepository.Get(id);
        if (vip is null)
        {
            return new VIPGetDto();
        }
        VIPGetDto mappedEntity = _mapper.Map<VIPGetDto>(vip);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(VIPPostDto dto)
    {
        VIP vip = _mapper.Map<VIP>(dto);
        _unitOfWork.VIPRepository.Add(vip);
        _unitOfWork.Save();
    }
    #endregion
}
