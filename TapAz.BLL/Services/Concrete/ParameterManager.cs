namespace TapAz.BLL.Services.Concrete;

public class ParameterManager : IParameterService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ParameterManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<ParameterGetDto> GetAll()
    {
        List<Parameter> parameters = _unitOfWork.ParameterRepository.Get();
        if (parameters is null)
        {
            return new List<ParameterGetDto> { new ParameterGetDto() };
        }
        return new List<ParameterGetDto>(_mapper.Map<List<ParameterGetDto>>(parameters));
    }

    public ParameterGetDto GetById(int id)
    {
        Parameter parameter = _unitOfWork.ParameterRepository.Get(id);
        if (parameter is null)
        {
            return new ParameterGetDto();
        }
        ParameterGetDto mappedEntity = _mapper.Map<ParameterGetDto>(parameter);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(ParameterPostDto dto)
    {
        Parameter parameter = _mapper.Map<Parameter>(dto);
        _unitOfWork.ParameterRepository.Add(parameter);
        _unitOfWork.Save();
    }
    #endregion
}
