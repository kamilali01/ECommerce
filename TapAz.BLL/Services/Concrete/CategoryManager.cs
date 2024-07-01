namespace TapAz.BLL.Services.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Get Requests
    public List<CategoryGetDto> GetAll()
    {
        List<Category> categories = _unitOfWork.CategoryRepository.Get();
        if (categories is null)
        {
            return new List<CategoryGetDto> { new CategoryGetDto() };
        }
        return new List<CategoryGetDto>(_mapper.Map<List<CategoryGetDto>>(categories));
    }

    public CategoryGetDto GetById(int id)
    {
        Category category = _unitOfWork.CategoryRepository.Get(id);
        if (category is null)
        {
            return new CategoryGetDto();
        }
        CategoryGetDto mappedEntity = _mapper.Map<CategoryGetDto>(category);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(CategoryPostDto dto)
    {
        Category category = _mapper.Map<Category>(dto);
        _unitOfWork.CategoryRepository.Add(category);
        _unitOfWork.Save();
    }
    #endregion
}
