namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FAQController : ControllerBase
{
    private readonly IFAQService _faqService;

    public FAQController(IFAQService faqService)
    {
        _faqService = faqService;
    }

    // GET: api/FAQ
    [HttpGet]
    public IActionResult GetAll()
    {
        var faqs = _faqService.GetAll();
        return Ok(faqs);
    }

    // GET: api/FAQ/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var faq = _faqService.GetById(id);

        if (faq == null)
        {
            return NotFound();
        }

        return Ok(faq);
    }

    // POST: api/FAQ
    [HttpPost]
    public IActionResult Create([FromBody] FAQPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("FAQ object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _faqService.Create(dto);

        return Created("GetById", dto);
    }
}