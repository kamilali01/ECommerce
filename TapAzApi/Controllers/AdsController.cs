namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AdsController : ControllerBase
{
    private readonly IAdsService _adsService;

    public AdsController(IAdsService adsService)
    {
        _adsService = adsService;
    }

    // GET: api/Ads
    [HttpGet]
    public IActionResult GetAll()
    {
        var ads = _adsService.GetAll();
        return Ok(ads);
    }

    // GET: api/Ads/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var ad = _adsService.GetById(id);

        if (ad == null)
        {
            return NotFound();
        }

        return Ok(ad);
    }

    // POST: api/Ads
    [HttpPost]
    public IActionResult Create([FromForm] AdsPostDto dto)
    {
        if (dto == null)
        { 
            return BadRequest("Ad object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _adsService.Create(dto);

        return Created("Get", dto);
    }
}
