using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> InhaltAbrufenAsync()
        {
            await Task.Delay(5000);

            var meineTask = new HttpClient().GetStringAsync("https://google.com");
            var daten=await meineTask;
            return Ok(daten);
        }
    }
}
