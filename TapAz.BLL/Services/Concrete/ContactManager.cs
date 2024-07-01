namespace TapAz.BLL.Services.Concrete;

public class ContactManager : IContactService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IWebHostEnvironment _env;
    private readonly IMapper _mapper;

    public ContactManager(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment env)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _env = env;
    }

    #region Get Requests
    public List<ContactGetDto> GetAll()
    {
        List<Contact> contacts = _unitOfWork.ContactRepository.Get();
        if (contacts is null)
        {
            return new List<ContactGetDto> { new ContactGetDto() };
        }
        return new List<ContactGetDto>(_mapper.Map<List<ContactGetDto>>(contacts));
    }

    public ContactGetDto GetById(int id)
    {
        Contact contact = _unitOfWork.ContactRepository.Get(id);
        if (contact is null)
        {
            return new ContactGetDto();
        }
        ContactGetDto mappedEntity = _mapper.Map<ContactGetDto>(contact);
        return mappedEntity;
    }

    #endregion

    #region Post Requests
    public void Create(ContactPostDto dto)
    {
        Contact contact = _mapper.Map<Contact>(dto);
        contact.IconPath = dto.IconPath.FileCreate(_env.WebRootPath, "uploads/contact");
        _unitOfWork.ContactRepository.Add(contact);
        _unitOfWork.Save();
    }
    #endregion
}
