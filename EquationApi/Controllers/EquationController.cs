using Microsoft.AspNetCore.Mvc;
using EquationApi.Models;
using EquationApi.Repositories;

namespace EquationApi.Controllers
{
    [ApiController]
    [Route("api/v1/equations")]
    public class EquationController : ControllerBase
    {

        private readonly ILogger<EquationController> _logger;
        private readonly IEquationRepository repository;

        public EquationController(ILogger<EquationController> logger)
        {
            _logger = logger;
            repository = new EquationRepository();
        }

        [HttpGet]
        public IEnumerable<Equation> Get(int qty)
        {
            return repository.GetEquations(qty).ToArray();
        }
    }
}