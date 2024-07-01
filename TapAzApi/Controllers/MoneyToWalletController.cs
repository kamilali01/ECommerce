namespace TapAzApi.Controllers;
[Authorize]
[Route("api/[controller]")]
[ApiController]
public class MoneyToWalletController : ControllerBase
{
    private readonly IMoneyToWalletService _moneyToWalletService;

    public MoneyToWalletController(IMoneyToWalletService moneyToWalletService)
    {
        _moneyToWalletService = moneyToWalletService;
    }

    // GET: api/MoneyToWallet
    [HttpGet]
    public IActionResult GetAll()
    {
        var transactions = _moneyToWalletService.GetAll();
        return Ok(transactions);
    }

    // GET: api/MoneyToWallet/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var transaction = _moneyToWalletService.GetById(id);

        if (transaction == null)
        {
            return NotFound();
        }

        return Ok(transaction);
    }

    // POST: api/MoneyToWallet
    [HttpPost]
    public IActionResult Create([FromBody] MoneyToWalletPostDto dto)
    {
        if (dto == null)
        {
            return BadRequest("Money transaction object is null");
        }

        if (!ModelState.IsValid)
        {
            return BadRequest("Invalid model object");
        }

        _moneyToWalletService.Create(dto);

        return Created("GetById", dto);
    }
}