using Microsoft.AspNetCore.Mvc;
using EquationApi.Models;

namespace EquationApi.Controllers
{
    [ApiController]
    [Route("api/v1/equations")]
    public class EquationController : ControllerBase
    {

        private readonly ILogger<EquationController> _logger;

        public EquationController(ILogger<EquationController> logger)
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