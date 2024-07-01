namespace TapAz.BLL.Services.Concrete;

public class UserManager : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UserManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    #region Get Requests
    public List<UserGetDto> GetAll()
    {
        List<User> users = _unitOfWork.UserRepository.Get();
        if (users is null)
        {
            return new List<UserGetDto> { new UserGetDto() };
        }
        return new List<UserGetDto>(_mapper.Map<List<UserGetDto>>(users));
    }

    public UserGetDto GetById(int id)
    {
        User user = _unitOfWork.UserRepository.Get(id);
        if (user is null)
        {
            return new UserGetDto();
        }
        UserGetDto mappedEntity = _mapper.Map<UserGetDto>(user);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(UserPostDto dto)
    {
        User user = _mapper.Map<User>(dto);
        _unitOfWork.UserRepository.Add(user);
        _unitOfWork.Save();
    }
    #endregion
}
