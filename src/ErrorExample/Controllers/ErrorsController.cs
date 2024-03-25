using Microsoft.AspNetCore.Mvc;

namespace ErrorExample.Controllers;

[Route("api/[controller]")]
public class ErrorsController : ControllerBase
{

    // GET api/errors/404
    [HttpGet("{errorcode}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(500)]
    public async Task<IActionResult> GenerateException(int errorcode)
    {
      Console.WriteLine(errorcode);
      return DummyMethod();
    }


    private IActionResult DummyMethod()
    {
      return DummyMethod2();
    }

    private IActionResult DummyMethod2()
    {
      try
      {
        int numerator = 10;
        int denominator = 0;
        int result = numerator / denominator;
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }

      return null;
    }
}
