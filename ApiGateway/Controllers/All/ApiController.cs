using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
namespace ApiGateway.Controllers.All
{
    [ApiController]
    [Route("api/all")]
    public class ApiController : ControllerBase
    {
        public string File(string path)
        {
            var result = System.IO.File.ReadAllText(path);


            return result;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllData(string input)
        {
            var data = File("C://database/data.json");

            data = data + (input.Replace("dai", ""));

            return Ok(data);
        }
    }
}
