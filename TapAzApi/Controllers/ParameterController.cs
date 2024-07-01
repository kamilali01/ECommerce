namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ParameterController : ControllerBase
{
    private readonly IParameterService _parameterService;

    public ParameterController(IParameterService parameterService)
    {
        _parameterService = parameterService;
    }

    // GET: api/Parameter
    [HttpGet]
    public IActionResult GetAll()
    {
        var parameters = _parameterService.GetAll();
        return Ok(parameters);
    }

    // GET: api/Parameter/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var parameter = _parameterService.GetById(id);

        if (parameter == null)
        {
            return NotFound();
        }

        return Ok(parameter);
    }

    // POST: api/Parameter
    [HttpPost]
    public IActionResult Create([FromBody] ParameterPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Parameter object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _parameterService.Create(dto);

        return Created("GetById", dto);
    }
}