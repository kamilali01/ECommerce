namespace TapAz.BLL.Services.Concrete;

public class FAQManager : IFAQService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FAQManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Get Requests
    public List<FAQGetDto> GetAll()
    {
        List<FAQ> faqs = _unitOfWork.FAQRepository.Get();
        if (faqs is null)
        {
            return new List<FAQGetDto> { new FAQGetDto() };
        }
        return new List<FAQGetDto>(_mapper.Map<List<FAQGetDto>>(faqs));
    }

    public FAQGetDto GetById(int id)
    {
        FAQ faq = _unitOfWork.FAQRepository.Get(id);
        if (faq is null)
        {
            return new FAQGetDto();
        }
        FAQGetDto mappedEntity = _mapper.Map<FAQGetDto>(faq);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(FAQPostDto dto)
    {
        FAQ faq = _mapper.Map<FAQ>(dto);
        _unitOfWork.FAQRepository.Add(faq);
        _unitOfWork.Save();
    }
    #endregion
}
