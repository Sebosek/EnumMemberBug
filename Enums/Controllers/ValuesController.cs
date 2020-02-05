using System.Linq;

using Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Enums.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(DataModel model)
        {
            _logger.LogInformation(string.Join(", ", model.Values.Select(s => s.ToString())));

            return Ok(model);
        }
    }
}
