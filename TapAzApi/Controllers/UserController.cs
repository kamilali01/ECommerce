namespace TapAzApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IJwtService _jwtService;

    public UserController(IUserService userService, IJwtService jwtService)
    {
        _userService = userService;
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] int number)
    {
        // Perform user authentication here and retrieve the user's ID
        var userList = _userService.GetAll();
        var userId = userList.FirstOrDefault(i=>i.Number == number);
        if (userId == null)
        {
            return BadRequest();
        }
        // Generate a JWT token
        var token = _jwtService.GenerateToken(userId.Id.ToString());

        // Return the token to the client
        return Ok(new { Token = token });
    }

    // GET: api/User
    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }

    // GET: api/User/5
    [Authorize]
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _userService.GetById(id);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    // POST: api/User
    [Authorize]
    [HttpPost]
    public IActionResult Create([FromBody] UserPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("User object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _userService.Create(dto);

        return Created("GetById", dto);
    }
}