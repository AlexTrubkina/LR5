using LR5.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LR5.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController : Controller
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "Hello World" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("geron")]
        public async Task<IActionResult> Geron()
        {
            SecondRequest request = new SecondRequest(this.Request);

            // S = (p − a) * (p − b), Площадь треугольника по формул Герона
            // p = p = (a + b + c) : 2 - полупериметр

            double p = 0.5 * (request.A + request.B + request.С);

            double s = (p - request.A) * (p - request.B);

            Response res = new Response();
            res.Success = "Alex";
            res.Result = s;
            res.Version = 1.1;
            return this.Json(res);
        }
    }

}