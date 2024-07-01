namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    // GET: api/Contact
    [HttpGet]
    public IActionResult GetAll()
    {
        var contacts = _contactService.GetAll();
        return Ok(contacts);
    }

    // GET: api/Contact/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var contact = _contactService.GetById(id);

        if (contact == null)
        {
            return NotFound();
        }

        return Ok(contact);
    }

    // POST: api/Contact
    [HttpPost]
    public IActionResult Create([FromBody] ContactPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Contact object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _contactService.Create(dto);

        return Created("GetById", dto);
    }
}