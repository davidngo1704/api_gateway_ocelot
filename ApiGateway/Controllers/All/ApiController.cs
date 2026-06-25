using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
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
            var data = File("E://database/data.json");
            data = data + (input.Replace("dai", ""));
            return Ok(Parse(data));
        }
        public object Parse(string input)
        {
            var result = JsonSerializer.Deserialize<object>(input);
            var data = result.ToString()
                .Replace("{", "")
                .Replace("}", "")
                .Replace("\"", "")
                .Replace("'", "")
                .Replace(":", "");

            return BusinessLogic(data);
        }
        public string BusinessLogic(string input)
        {
            var data =input + "Dep trai";
            return data;
        }
    }
}
