namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class VIPController : ControllerBase
{
    private readonly IVIPService _vipService;

    public VIPController(IVIPService vipService)
    {
        _vipService = vipService;
    }

    // GET: api/VIP
    [HttpGet]
    public IActionResult GetAll()
    {
        var vipServices = _vipService.GetAll();
        return Ok(vipServices);
    }

    // GET: api/VIP/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var vipService = _vipService.GetById(id);

        if (vipService == null)
        {
            return NotFound();
        }

        return Ok(vipService);
    }

    // POST: api/VIP
    [HttpPost]
    public IActionResult Create([FromBody] VIPPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("VIP service object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _vipService.Create(dto);

        return Created("GetById", dto);
    }
}