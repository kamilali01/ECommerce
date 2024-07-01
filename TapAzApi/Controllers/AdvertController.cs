namespace TapAzApi.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AdvertController : ControllerBase
{
    private readonly IAdvertService _advertService;

    public AdvertController(IAdvertService advertService)
    {
        _advertService = advertService;
    }

    // GET: api/Advert
    [HttpGet]
    public IActionResult GetAll()
    {
        var adverts = _advertService.GetAll();
        return Ok(adverts);
    }

    // GET: api/Advert/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var advert = _advertService.GetById(id);

        if (advert == null)
        {
            return NotFound();
        }

        return Ok(advert);
    }

    // POST: api/Advert
    [HttpPost]
    public IActionResult Create([FromForm] AdvertPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Advert object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _advertService.Create(dto);

        return Created("GetById",dto);
    }
}
