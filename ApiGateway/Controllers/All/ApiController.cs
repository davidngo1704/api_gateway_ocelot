using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiGateway.Controllers.All
{
    [ApiController]
    [Route("api/all")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllData()
        {
            // Implementation for retrieving all data
            return Ok(new { message = "All data endpoint" });
        }
    }
}
