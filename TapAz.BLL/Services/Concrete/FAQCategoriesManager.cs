namespace TapAz.BLL.Services.Concrete;

public class FAQCategoriesManager : IFAQCategoriesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FAQCategoriesManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<FAQCategoriesGetDto> GetAll()
    {
        List<FAQCategories> fAQCategories = _unitOfWork.FAQCategoriesRepository.Get();
        if (fAQCategories is null)
        {
            return new List<FAQCategoriesGetDto> { new FAQCategoriesGetDto() };
        }
        return new List<FAQCategoriesGetDto>(_mapper.Map<List<FAQCategoriesGetDto>>(fAQCategories));
    }

    public FAQCategoriesGetDto GetById(int id)
    {
        FAQCategories fAQCategory = _unitOfWork.FAQCategoriesRepository.Get(id);
        if (fAQCategory is null)
        {
            return new FAQCategoriesGetDto();
        }
        FAQCategoriesGetDto mappedEntity = _mapper.Map<FAQCategoriesGetDto>(fAQCategory);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(FAQCategoriesPostDto dto)
    {
        FAQCategories fAQCategory = _mapper.Map<FAQCategories>(dto);
        _unitOfWork.FAQCategoriesRepository.Add(fAQCategory);
        _unitOfWork.Save();
    }
    #endregion
}
