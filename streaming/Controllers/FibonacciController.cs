using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace streaming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet("{numero}")]
        public double FibonacciRecursivo(int numero)
        {
            return
            Enumerable.Range(1, numero)
                     .Skip(2)
                     .Aggregate(new {  Current = 1.0, Prev = 1.0 },
                                (x, index) => new { Current = x.Prev + x.Current, Prev = x.Current })
                     .Current;
        }
    }
}
