using apitest.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
     
{
    private readonly IFibonacci _fibonacci;


    public FibonacciController(IFibonacci fibonacci)
    {
        _fibonacci = fibonacci; 
    }

    [HttpGet(Name = "GetFibonacci")]
    public int GetFibonacci(int num)
    {

        if (num < 2)
        {
            return num;
        }
        else
        {
            return _fibonacci.GetFibonacci(num);
        }
       
      
    }
}

