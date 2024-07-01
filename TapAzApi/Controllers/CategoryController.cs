namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    // GET: api/Category
    [HttpGet]
    public IActionResult GetAll()
    {
        var categories = _categoryService.GetAll();
        return Ok(categories);
    }

    // GET: api/Category/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var category = _categoryService.GetById(id);

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }

    // POST: api/Category
    [HttpPost]
    public IActionResult Create([FromBody] CategoryPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Category object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _categoryService.Create(dto);

        return Created("GetById", dto);
    }
}
