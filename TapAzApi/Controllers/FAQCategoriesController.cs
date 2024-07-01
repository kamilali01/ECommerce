namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FAQCategoryController : ControllerBase
{
    private readonly IFAQCategoriesService _faqCategoryService;

    public FAQCategoryController(IFAQCategoriesService faqCategoryService)
    {
        _faqCategoryService = faqCategoryService;
    }

    // GET: api/FAQCategory
    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = _faqCategoryService.GetAll();
        return Ok(categories);
    }

    // GET: api/FAQCategory/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _faqCategoryService.GetById(id);

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    // POST: api/FAQCategory
    [HttpPost]
    public IActionResult Create([FromBody] FAQCategoriesPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("FAQ category object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _faqCategoryService.Create(dto);

        return Created("GetById", dto);
    }
}