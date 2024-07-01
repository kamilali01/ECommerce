namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class PremiumController : ControllerBase
{
    private readonly IPremiumService _premiumService;

    public PremiumController(IPremiumService premiumService)
    {
        _premiumService = premiumService;
    }

    // GET: api/Premium
    [HttpGet]
    public IActionResult GetAll()
    {
        var premiumServices = _premiumService.GetAll();
        return Ok(premiumServices);
    }

    // GET: api/Premium/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var premiumService = _premiumService.GetById(id);

        if (premiumService == null)
        {
            return NotFound();
        }

        return Ok(premiumService);
    }

    // POST: api/Premium
    [HttpPost]
    public IActionResult Create([FromForm] PremiumPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Premium service object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _premiumService.Create(dto);

        return Created("GetById", dto);
    }
}