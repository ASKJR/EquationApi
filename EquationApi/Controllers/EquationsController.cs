using Microsoft.AspNetCore.Mvc;
using EquationApi.Models;

namespace EquationApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquationsController : ControllerBase
    {

        private readonly ILogger<EquationsController> _logger;

        public EquationsController(ILogger<EquationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Equation> Get()
        {
            //TODO: add repository to fetch equations
            return Enumerable.Range(1, 5).Select(index => new Equation())
            .ToArray();
        }
    }
}