namespace TapAz.BLL.Services.Concrete;

public class AdvertQuestionManager : IAdvertQuestionService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AdvertQuestionManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Get Requests
    public List<AdvertQuestionGetDto> GetAll()
    {
        List<AdvertQuestion> advertQuestions = _unitOfWork.AdvertQuestionRepository.Get();
        if (advertQuestions is null)
        {
            return new List<AdvertQuestionGetDto> { new AdvertQuestionGetDto() };
        }
        return new List<AdvertQuestionGetDto>(_mapper.Map<List<AdvertQuestionGetDto>>(advertQuestions));
    }

    public AdvertQuestionGetDto GetById(int id)
    {
        AdvertQuestion advertQuestion = _unitOfWork.AdvertQuestionRepository.Get(id);
        if (advertQuestion is null)
        {
            return new AdvertQuestionGetDto();
        }
        AdvertQuestionGetDto mappedEntity = _mapper.Map<AdvertQuestionGetDto>(advertQuestion);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(AdvertQuestionPostDto dto)
    {
        AdvertQuestion advertQuestion = _mapper.Map<AdvertQuestion>(dto);
        _unitOfWork.AdvertQuestionRepository.Add(advertQuestion);
        _unitOfWork.Save();
    }
    #endregion

}