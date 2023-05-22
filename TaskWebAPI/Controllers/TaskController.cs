using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        #region CancellationToken-1
        //[HttpGet]
        //public async Task<IActionResult> InhaltAbrufenAsync()
        //{
        //    await Task.Delay(5000);

        //    var meineTask = new HttpClient().GetStringAsync("https://google.com");
        //    var daten=await meineTask;
        //    return Ok(daten);
        //}
        #endregion

        #region Cancellation-2
        private readonly ILogger<TaskController> _logger;
        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> InhaltAbrufenAsync(CancellationToken cancellation)
        {
            #region Asekron
            try
            {
                _logger.LogInformation("Die Anfrage wurde gestartet");
                await Task.Delay(5000, cancellation);

                var meineTask = new HttpClient().GetStringAsync("https://google.com");
                var daten = await meineTask;
                _logger.LogInformation("Die Anfrage ist beendet.");
                return Ok(daten);
            }
            catch (Exception exception)
            {

                _logger.LogInformation("Die Anfrage wurde storniert." + exception.Message);

                return BadRequest();
            }
            #endregion

            #region Sekron
            //try
            //{

            //    _logger.LogInformation("Die Anfrage wurde gestartet");

            //    Enumerable.Range(1, 10).ToList().ForEach(x =>
            //    {
            //        Thread.Sleep(1000);
            //        cancellation.ThrowIfCancellationRequested();
            //    });

            //    _logger.LogInformation("Die Anfrage ist beendet.");
            //    return Ok("Transaktion wurde beendet");

            //}
            //catch (Exception exception)
            //{

            //    _logger.LogInformation("Die Anfrage wurde storniert." + exception.Message);

            //    return BadRequest();
            //}
            #endregion
        }
        #endregion
    }
}
