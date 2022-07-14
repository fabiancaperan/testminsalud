using apitest.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers;

[ApiController]
[Route("[controller]")]
public class BisiestoController : ControllerBase
     
{
    private readonly IBisiesto _bisiesto;


    public BisiestoController(IBisiesto bisiesto)
    {
        _bisiesto = bisiesto; 
    }

    [HttpGet(Name = "GetBisiesto")]
    public string GetBisiesto(int num)
    {
            return _bisiesto.GetBisisesto(num)?"es bisiesto":"no es bisiesto";
      
    }
}

