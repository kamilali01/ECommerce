namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly ICityService _cityService;

    public CityController(ICityService cityService)
    {
        _cityService = cityService;
    }

    // GET: api/City
    [HttpGet]
    public IActionResult GetAll()
    {
        var cities = _cityService.GetAll();
        return Ok(cities);
    }

    // GET: api/City/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var city = _cityService.GetById(id);

        if (city == null)
        {
            return NotFound();
        }

        return Ok(city);
    }

    // POST: api/City
    [HttpPost]
    public IActionResult Create([FromBody] CityPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("City object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _cityService.Create(dto);

        return Created("GetById", dto);
    }
}