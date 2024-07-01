namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AdvertQuestionController : ControllerBase
{
    private readonly IAdvertQuestionService _advertQuestionService;

    public AdvertQuestionController(IAdvertQuestionService advertQuestionService)
    {
        _advertQuestionService = advertQuestionService;
    }

    // GET: api/AdvertQuestion
    [HttpGet]
    public IActionResult GetAll()
    {
        var questions = _advertQuestionService.GetAll();
        return Ok(questions);
    }

    // GET: api/AdvertQuestion/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var question = _advertQuestionService.GetById(id);

        if (question == null)
        {
            return NotFound();
        }

        return Ok(question);
    }

    // POST: api/AdvertQuestion
    [HttpPost]
    public IActionResult Create([FromBody] AdvertQuestionPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("AdvertQuestion object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _advertQuestionService.Create(dto);

        return Created("GetById", dto);
    }
}
