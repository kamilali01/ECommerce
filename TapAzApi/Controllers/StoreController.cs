namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
    private readonly IStoreService _storeService;

    public StoreController(IStoreService storeService)
    {
        _storeService = storeService;
    }

    // GET: api/Store
    [HttpGet]
    public IActionResult GetAll()
    {
        var stores = _storeService.GetAll();
        return Ok(stores);
    }

    // GET: api/Store/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var store = _storeService.GetById(id);

        if (store == null)
        {
            return NotFound();
        }

        return Ok(store);
    }

    // POST: api/Store
    [HttpPost]
    public IActionResult Create([FromBody] StorePostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Store object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _storeService.Create(dto);

        return Created("GetById", dto);
    }
}