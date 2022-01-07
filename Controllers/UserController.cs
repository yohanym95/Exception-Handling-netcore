using ExceptionHandling.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionHandling.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly IUserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController(IUserService userService, ILogger<UserController> logger)
    {
        _userService = userService;
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult GetUsers()
    {
        
        _logger.LogInformation("Getting Users details");

        var result = _userService.GetUsers();
        if (result.Count == 0)
            throw new KeyNotFoundException("Users not found. Try again");

        return Ok(result);
        
    }
}