namespace TapAz.BLL.Services.Abstract;

public interface IGenericService<TGetDto, TPostDto, TUpdateDto>
    where TGetDto : class, IDto, new()
    where TPostDto : class, IDto, new()
    where TUpdateDto : class, IDto, new()
{
    List<TGetDto> GetAll();
    TGetDto GetById(int id);
    void Create(TPostDto dto);
}